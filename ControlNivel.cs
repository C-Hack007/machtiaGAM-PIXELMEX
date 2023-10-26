using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNivel : MonoBehaviour
{
    // Start is called before the first frame update

    public void Lv1()
    {
        SceneManager.LoadScene("level1");
    }

    public void Lv2()
    {
        SceneManager.LoadScene("level2");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    }

