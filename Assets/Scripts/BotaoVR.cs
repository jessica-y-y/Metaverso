using UnityEngine;

/// <summary>
/// Detecta clique do mouse no botão (modo PC/Editor).
/// Chama o método correspondente no MenuYoga.
/// </summary>
public class BotaoVR : MonoBehaviour
{
    public enum TipoPratica { Yoga, Pranayama }
    public TipoPratica tipoPratica;

    private MenuYoga menuYoga;

    void Start()
    {
        // Busca o MenuYoga no objeto pai
        menuYoga = GetComponentInParent<MenuYoga>();
    }

    // Detecta clique do mouse sobre o objeto
    private void OnMouseDown()
    {
        if (tipoPratica == TipoPratica.Yoga)
            menuYoga.SelecionarYoga();
        else
            menuYoga.SelecionarPranayama();
    }
}