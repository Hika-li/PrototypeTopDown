using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Je suis rentré dans la zone");
        GameManager.InstanceGameManager.OnEndTrigger();
    }
}
