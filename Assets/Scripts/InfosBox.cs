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


    [SerializeField]
    GameObject Video;

    [SerializeField]
    Transform cam;

    GameObject muestra;
    public void StartTalking()
    {
        Destroy(muestra);
        infoBox.gameObject.SetActive(true);
        Video.gameObject.SetActive(true);
        Debug.Log("colision player");
        imagen.sprite = zona.image;
        titulo.text = zona.titulo;
        descripcion.text = zona.description;

        muestra = Instantiate(zona.Model,zona.Model.transform.position,zona.Model.transform.rotation);
        

        

    }





    public void StopTalking()
    {
        infoBox.gameObject.SetActive(false);
        Video.gameObject.SetActive(false);
        
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
            Destroy(muestra);
        }

        


    }
     void Start()
    {
        imagen.sprite = zona.image;
        titulo.text = zona.titulo;
        descripcion.text = zona.description;
    }

    
}
