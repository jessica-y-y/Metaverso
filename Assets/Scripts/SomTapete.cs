using UnityEngine;

public class Somtapete : MonoBehaviour
{
    private AudioSource audioSource;  
    
    void Start()
    {
        //busca o audio
        audioSource = GetComponent<AudioSource>();
    }

    //chamado quando o player entra no trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

}
