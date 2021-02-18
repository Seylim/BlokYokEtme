using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagenment : MonoBehaviour
{
    //Herhangi bir sahneye geçiş yapmak için kullanılan fonksiyon.
    public void Scene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //Oyun sahnesi
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Blocks.totalBlockNumber = 0;
    }

    //Oyunun başlangıcındaki ilk sahne.
    public void HomePage()
    {
        SceneManager.LoadScene(0);
    }

    //Uygulamayı sonlandıran fonksiyon.
    public void ExitApplication()
    {
        Application.Quit();
    }
    public void WinnerScreen()
    {
        SceneManager.LoadScene(2);
    }

    //Oyun kaybetme sahnesi. 
    public void LoseScreen()
    {
        SceneManager.LoadScene(3);
    }
}
