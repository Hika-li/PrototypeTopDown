using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager InstanceGameManager;
    void Awake()
    {
        InstanceGameManager = this;
        DontDestroyOnLoad(this.gameObject);
    }
    public void OnButtonPlay()
    {
        Debug.Log("Button Play pushed");
        SceneManager.LoadScene("Scenes/GameScene");
    }

    public void OnEndTrigger()
    {
        Debug.Log("End Trigger");
        SceneManager.LoadScene("Scenes/EndScene");
    }
    
    
}
