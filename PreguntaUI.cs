using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaUI : MonoBehaviour
{
    private void Start()
    {
        // Ocultar la interfaz de preguntas al inicio
        DesactivarPreguntas();
    }

    public void ActivarPreguntas()
    {
        // Lógica para activar la interfaz de preguntas
        gameObject.SetActive(true);
    }

    public void DesactivarPreguntas()
    {
        // Lógica para desactivar la interfaz de preguntas
        gameObject.SetActive(false);
    }
}

