using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Camera Scene Load
    public void CameraScene()
    {
        //Next Scene Load
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //Menu Scene Load
    public void MenuScene()
    {
        //Previous Scene Load 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
