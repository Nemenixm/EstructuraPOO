using UnityEngine;

public class Item : MonoBehaviour
{
     protected string nombre;
    protected string descripcion;

  
    // PROPIEDADES
    public string Nombre => nombre;
    public string Descripcion => descripcion;

   
    // MÉTODOS
    public virtual void Usar(Player player)
    {
        
        Debug.Log("Usando item: " + nombre);
    }
 
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
