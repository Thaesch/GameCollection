using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartReset : MonoBehaviour
{

    [SerializeField] private GameObject snake;

    private void Update()
    {
        if(!snake || !snake.activeSelf)
        {
            Restart();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
