using UnityEngine;

public class Fruta : MonoBehaviour
{
    // ATRIBUTOS
    private int regenerarResistencia = 20;
    private int reducirHambre = 30;

    
    // MÉTODOS
   
    public void Comer(Player player)
    {
        if (player == null) return;

        player.RecuperarResistencia(regenerarResistencia);
        player.ReducirHambre(reducirHambre);

        Debug.Log("Fruta comida");
        Destroy(gameObject);
    }
}
