using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    public void MoveGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void MoveStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    
    
}
