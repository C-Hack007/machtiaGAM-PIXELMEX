using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaManager : MonoBehaviour
{
    public Pregunta[] preguntas;
    private int preguntaActual = 0;

    public bool RespuestaCorrecta { get; private set; }

    public string ObtenerPreguntaActual()
    {
        return preguntas[preguntaActual].pregunta;
    }

    public string[] ObtenerOpcionesRespuestaActual()
    {
        return preguntas[preguntaActual].opcionesRespuesta;
    }

    public void VerificarRespuesta(int opcionSeleccionada)
    {
        if (preguntas[preguntaActual].opcionCorrecta == opcionSeleccionada)
        {
            RespuestaCorrecta = true;
        }
        else
        {
            RespuestaCorrecta = false;
        }
        preguntaActual++;

        if (preguntaActual >= preguntas.Length)
        {
            preguntaActual = 0; // Reiniciar el cuestionario si se llega al final
        }
    }
}

[System.Serializable]
public class Pregunta
{
    public string pregunta;
    public string[] opcionesRespuesta;
    public int opcionCorrecta;
}
