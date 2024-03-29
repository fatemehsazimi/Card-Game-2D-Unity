using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void ExitGame(){
        Debug.Log("Exit");
        Application.Quit();
    }
    public void GuideBtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }
    public void BackBtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
