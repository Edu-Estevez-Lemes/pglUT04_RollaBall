using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    public TMP_Text countText;
    public TMP_Text winText;
    public GameObject nextLevelButton;

    
    public float speed = 10.0f;
    public float jumpForce = 5.0f;         // fuerza del salto
    public LayerMask groundMask;           // capa del suelo

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    private bool isGrounded = false;

    public GameObject endPanel;           // Referencia al panel final con lo botones

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.gameObject.SetActive(false);

        if (endPanel != null )
            endPanel.SetActive(false);    // Al igual que el winText, nos aseguramos de que el panel final esté oculto desde el principio

        if (nextLevelButton != null )
            nextLevelButton.SetActive(false);
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnJump(InputValue jumpValue)
    {
        // Este método se ejecutará al pulsar la barra espaciadora (cuando lo configuremos en Input Actions)
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void Update()
    {
        // Comprobamos si está tocando el suelo (raycast corto hacia abajo)
        float rayDistance = 0.6f;
        isGrounded = Physics.Raycast(transform.position, Vector3.down, rayDistance, groundMask);
    }

    void LateUpdate()
    {
        // Si la bola cae fuera del escenario (por ejemplo, por debajo de Y = -2)
        if (transform.position.y < -2f)
        {

            // Mostrar el panel de fin de partida
            if (endPanel != null)
            {
                endPanel.SetActive(true);
            }

            // Opcional: detener el movimiento de la bola
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            // Bloquear el control (para que no siga moviéndose)
            this.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.gameObject.SetActive(true);


            if(endPanel != null)
                endPanel.SetActive(true);   // Al llegar a la puntuación máxima se visibiliza el endPanel

            if (nextLevelButton != null)
                nextLevelButton.SetActive(true);  // Activamos el botón de Next Level solo si se llega a la puntuación indicada
        }
    }

    public void NextLevel()
    {
       
        SceneManager.LoadScene("Level02");

    }

    public void RestardGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Para el editor
#else
        Application.Quit(); // Para el build final
#endif

    }



}
