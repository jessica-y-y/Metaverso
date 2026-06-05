using UnityEngine;

/// <summary>
/// Toca som e exibe o menu de seleção quando o player entra no tapete.
/// </summary>
public class SomTapete : MonoBehaviour
{
    public GameObject menuYoga; // Arraste o Menu_Yoga aqui no Inspector

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Garante que o menu começa inativo
        if (menuYoga != null)
            menuYoga.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!audioSource.isPlaying)
                audioSource.Play();

            // Ativa o menu de seleção
            if (menuYoga != null)
                menuYoga.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Esconde o menu quando o player sai do tapete
        if (other.CompareTag("Player"))
        {
            if (menuYoga != null)
                menuYoga.SetActive(false);
        }
    }
}