using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public void Pausa()
    {
        Time.timeScale = 0f;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
        }


    }
}
