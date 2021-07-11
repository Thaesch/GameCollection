using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    float sceneInit;

    private void Start()
    {
        sceneInit = Time.time;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(Input.GetMouseButtonDown(0) && Time.time > sceneInit + 0.3f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
