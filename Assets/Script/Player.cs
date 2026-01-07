using UnityEngine;

public class Player : MonoBehaviour
{

    // ATRIBUTOS (privados)

    private int vidaMaxima = 100;
    private int vidaActual;
    private float velocidad = 5f;
    private int dañoBase = 10;
    private float resistencia = 100;
    private int hambre = 100;
    private int sed = 100;
    private bool EstaVivo;
    private Inventario inventario;



    // PROPIEDADES (públicas)

    public int Vida;
    public float Velocidad;
    public int Daño;
    

    private void Start()
    {
        vidaActual = vidaMaxima;
        inventario = new Inventario(10);
        
    }

    private void Update()
    {
        Debug.Log("La vida actual es de: " + Vida);
        Debug.Log("El player tiene una velocidad: " + Velocidad);
        Debug.Log("El player ataca con daño: " + Daño);
    }

    
    // MÉTODOS PÚBLICOS
    
    public void Atacar()
    {
        Debug.Log("El player ataca con daño: " + Daño);
    }

    public void RecibirDaño()
    {
       
    }

    public void Comer()
    {
         if (hambre <= 20)
        {
            Debug.Log("Tu  es muy baja. Duerme para recuperar energía");
        }
    }

    public void Dormir()
    {
        if (resistencia <= 20)
        {
            Debug.Log("Tu resistencia es muy baja. Duerme para recuperar energía");
        }
    }

        public void RecuperarResistencia(int cantidad)
    {
        resistencia = Mathf.Min(resistencia + cantidad, 100);
    }
    public void ReducirHambre(int cantidad)
    {
        hambre = Mathf.Max(hambre + cantidad, 100);
    }

    public void CogerItem()
    {
        
    }

    public void SoltarItem()
    {
        
    }

    private void Morir()
    {
         if (vidaMaxima <= 0)
        {
            Debug.Log("Has muerto");
        }
    }
}
