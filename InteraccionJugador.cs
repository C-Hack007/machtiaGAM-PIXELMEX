using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionJugador : MonoBehaviour
{
    public PreguntaManager preguntaManager;
    public GameObject preguntaUI;

    private void OnMouseDown()
    {
        preguntaUI.SetActive(true); // Activa la interfaz de preguntas
    }
}
