using UnityEngine;

public class MusicManager : MonoBehaviour
{

    private static MusicManager instance;
    private AudioSource audioSource;


    private void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }

    }
    
    void Start()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }

}
