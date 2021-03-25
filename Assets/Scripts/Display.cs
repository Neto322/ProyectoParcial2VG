using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    [SerializeField]
    Text titulo;

    [SerializeField]
    Text descripcion;


    public string InfoTitulo
    {
        set =>titulo.text = value;
    }
    public string InfoDescripcion
    {
        set =>descripcion.text = value;
    }

    
}
