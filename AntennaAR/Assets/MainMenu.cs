using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Camera kép megjelenítése
    public void CameraScene()
    {
        //Következő scene betöltése 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Kilépés
    public void QuiGame()
    {
        //App Bezárása
        Debug.Log("Quit!");
       
        Application.Quit();
    }
    
}
