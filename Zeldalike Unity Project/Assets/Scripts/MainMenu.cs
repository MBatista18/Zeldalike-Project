using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public GameObject AudioManager;
    public void KillMusic()
    {
        Destroy(GameObject.Find("AudioManager"));
        PlayButton();
    }
    
    public void PlayButton ()
    {
        SceneManager.LoadScene("IntroScene");
    }
    public void GameScene()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void BackScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
