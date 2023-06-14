using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  


public class playbutton : MonoBehaviour
{
    public void MoveToScene(int sceneid){
    SceneManager.LoadScene(sceneid);
} 
}
