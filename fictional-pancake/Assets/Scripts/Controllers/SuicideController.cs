using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuicideController : MonoBehaviour
{
    
    public void ChangeScene(string gameScene) 
    {
        SceneManager.LoadScene(gameScene);
    }
}
