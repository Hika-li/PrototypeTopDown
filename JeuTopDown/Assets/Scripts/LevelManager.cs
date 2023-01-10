using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Door _door;
    private int numberOfBox;
    
    public static LevelManager InstanceLevelManager;
    
    private void Awake()
    {
        InstanceLevelManager = this;
    }

    public void OpenTheGate()
    {
        _door.Open();
    }
    
}
