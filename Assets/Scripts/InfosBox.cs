using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfosBox : MonoBehaviour
{
    [SerializeField]
    Zona zona;

    [SerializeField]
    GameObject infoBox;

    [SerializeField]
    Image imagen;

    [SerializeField]
    Text titulo;

    [SerializeField]
    Text descripcion;

    float distancia;



    public void StartTalking()
    {
        infoBox.gameObject.SetActive(true);
        Debug.Log("colision player");
        imagen.sprite = zona.image;
        titulo.text = zona.titulo;
        descripcion.text = zona.description;

    }
    public void StopTalking()
    {
        infoBox.gameObject.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartTalking();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StopTalking();
        }
    }
     void Start()
    {
        imagen.sprite = zona.image;
        titulo.text = zona.titulo;
        descripcion.text = zona.description;
    }

    
}
