using UnityEngine;

public class Arma : MonoBehaviour
{
    // ATRIBUTOS
    private int daño = 25;
    private int capacidadCargador = 25;
    private int balasActuales;
    private int durabilidad = 100;


    // PROPIEDADES
    public int Daño => daño;
    public bool TieneBalas => balasActuales > 0;
    public bool EstaRota => durabilidad <= 0;

    private void Start()
    {
        balasActuales = capacidadCargador;
    }


    // MÉTODOS
    public void Disparar(Player player)
    {
        if (!TieneBalas || EstaRota)
        {
            Debug.Log("No puedes utilizar este arma");
        }

    }

    public void Recargar()
    {
        balasActuales = capacidadCargador;
        Debug.Log("Arma recargada");
    }
}
