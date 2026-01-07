using UnityEngine;

public class Zombie : MonoBehaviour
{
     private int vidaMaximaZombie = 300;
    private int vidaActualZombie;
    private float velocidad = 2f;
    private int dañoBase = 35;
    


    // PROPIEDADES (públicas)

    public int Vida;
   
    public int Daño;
    

    private void Start()
    {
        vidaActualZombie = vidaMaximaZombie;
        
    }

    private void Update()
    {
        Debug.Log("La vida actual del zombi es de: " + Vida);
        Debug.Log("El zombie ataca con daño: " + Daño);
    }

    
    // MÉTODOS PÚBLICOS
    
    public void Atacar()
    {
        Debug.Log("El zombie ataca con daño: " + Daño);
    }

    public void RecibirDaño()
    {
       
    }

   
    private void Morir()
    {
         if (vidaMaximaZombie <= 0)
        {
            Debug.Log("Has matado al zombie");
        }
    }
}
