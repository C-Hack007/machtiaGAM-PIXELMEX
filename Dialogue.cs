using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; // Importa el namespace necesario para trabajar con botones.

public class Dialogue : MonoBehaviour
{
    [SerializeField] private GameObject dialogueMark;

    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;

    [SerializeField] private Button buttonDestroy; // Agrega referencia al botón de destrucción.
    [SerializeField] private Button buttonCancel;  // Agrega referencia al botón de cancelación.

    private float typingTime = 0.05f;

    private bool isPlayerInRange;
    private bool didDialogueStart;
    private int lineIndex;

    void Start()
    {
        buttonDestroy.gameObject.SetActive(false);
        buttonCancel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            if (!didDialogueStart)
            {
                StartDialogue();
            }
            else if (dialogueText.text == dialogueLines[lineIndex])
            {
                NextDialogueLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogueLines[lineIndex];
            }
        }
    }

    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        dialogueMark.SetActive(false);
        lineIndex = 0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());

        buttonDestroy.gameObject.SetActive(true); // Activa el botón de destrucción.
        buttonCancel.gameObject.SetActive(true);  // Activa el botón de cancelación.
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            dialogueMark.SetActive(false);
            Time.timeScale = 1f;

            buttonDestroy.gameObject.SetActive(false); // Desactiva el botón de destrucción.
            buttonCancel.gameObject.SetActive(false);  // Desactiva el botón de cancelación.
        }
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;

        foreach (char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            dialogueMark.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            dialogueMark.SetActive(false);
        }
    }
}
