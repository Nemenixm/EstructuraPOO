using UnityEngine;
using System.Collections.Generic;


public class Inventario 
{
    private int capacidad;
    private List<Item> objetos;
    public int Capacidad => capacidad;
     public Inventario(int capacidadInicial)
    {
        capacidad = capacidadInicial;
        objetos = new List<Item>();
    }

    public bool AñadirObjeto(Item objeto)
    {
        if (objetos.Count >= capacidad)
            return false;

        objetos.Add(objeto);
        return true;
    }

    public bool SoltarObjeto(Item objeto)
    {
        return objetos.Remove(objeto);
    }
}
