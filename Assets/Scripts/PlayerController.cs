using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("UI")]
    public TMP_Text countText;
    public TMP_Text winText;

    [Header("Movimiento")]
    public float speed = 10.0f;
    public float jumpForce = 5.0f;         // fuerza del salto
    public LayerMask groundMask;           // capa del suelo

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.gameObject.SetActive(false);
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
        }
    }
}
