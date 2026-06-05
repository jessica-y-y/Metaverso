using UnityEngine;

public class MenuYoga : MonoBehaviour
{
    [Header("Referencias dos Botoes")]
    public GameObject botaoYoga;
    public GameObject botaoPranayama;

    [Header("Materiais")]
    public Material matSelecionado;
    public Material matBotaoYoga;
    public Material matBotaoPranayama;

    public void SelecionarYoga()
    {
        AplicarSelecao(botaoYoga, botaoPranayama);
        Debug.Log("Yoga selecionado");
    }

    public void SelecionarPranayama()
    {
        AplicarSelecao(botaoPranayama, botaoYoga);
        Debug.Log("Pranayama selecionado");
    }

    private void AplicarSelecao(GameObject ativo, GameObject inativo)
    {
        if (matSelecionado != null)
        {
            ativo.GetComponent<Renderer>().material = matSelecionado;

            Material matInativo = inativo == botaoYoga ? matBotaoYoga : matBotaoPranayama;
            inativo.GetComponent<Renderer>().material = matInativo;
        }
    }
}