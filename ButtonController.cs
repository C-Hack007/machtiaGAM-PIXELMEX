using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Agrega la directiva para utilizar la clase Button.

public class ButtonController : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject dialoguePanel;
    public Button buttonDestroy;
    public Button buttonCancel;

    public void DestroyObject()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }

    public void CancelDialogue()
    {
        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false); // Desactiva el panel de diálogo.
            Time.timeScale = 1f;           // Reanuda el tiempo normal del juego.

            // Desactiva los botones al cancelar el diálogo.
            buttonDestroy.gameObject.SetActive(false);
            buttonCancel.gameObject.SetActive(false);
        }
    }
}

