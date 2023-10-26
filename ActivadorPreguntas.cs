using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorPreguntas : MonoBehaviour
{
    public PreguntaUI preguntaUI; // Referencia al objeto PreguntaUI

    private void OnMouseDown()
    {
        preguntaUI.ActivarPreguntas();
    }
}
