using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaBloqueo : MonoBehaviour
{
    public PreguntaManager preguntaManager;
    public GameObject puerta; // Referencia al objeto de la puerta o bloqueo

    private bool puertaDesbloqueada = false;

    private void Update()
    {
        if (preguntaManager.RespuestaCorrecta && !puertaDesbloqueada)
        {
            puerta.SetActive(false); // Desactiva el objeto de la puerta para "abrir" la puerta
            puertaDesbloqueada = true;
        }
    }
}
