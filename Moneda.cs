using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [SerializeField] private GameObject efecto;

    [SerializeField] private float cantidadPuntos;



    private void OntriggerEnter2D(Collider2D other)
    {
        

        if (other.CompareTag("Player"))
        {
          ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
          Destroy(gameObject);
        }
    
    }

}
