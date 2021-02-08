using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagenment : MonoBehaviour
{
    public void Scene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void HomePage()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void LoseScreen()
    {
        SceneManager.LoadScene(3);
    }
}
