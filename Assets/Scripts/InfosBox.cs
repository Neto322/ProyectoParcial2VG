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


[SerializeField]
    GameObject[] pointers;

[SerializeField]
GameObject singlepointer;

[SerializeField]
GameObject seleccion;
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
        for(int i = 0; i < pointers.Length;i++)
            {
                pointers[i].SetActive(false);
            }

        

    }




    public void StopTalking()
    {            
        Destroy(muestra);
        infoBox.gameObject.SetActive(false);
        Video.gameObject.SetActive(false);
        
            for(int i = 0; i < pointers.Length;i++)
            {
                pointers[i].SetActive(true);
            }
            Destroy(singlepointer);

    }


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartTalking();
        }

        seleccion.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StopTalking();
        }
        seleccion.SetActive(false);




    }
     void Start()
    {
        imagen.sprite = zona.image;
        titulo.text = zona.titulo;
        descripcion.text = zona.description;
        seleccion.SetActive(false);

    }

  
    
}
