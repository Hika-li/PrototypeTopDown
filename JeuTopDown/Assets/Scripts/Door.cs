using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Open()
    {
        Debug.Log("La porte est ouverte");
        _animator.SetTrigger("OpenDoor");
        
    }
}
