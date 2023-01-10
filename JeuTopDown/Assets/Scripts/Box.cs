using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoxTouched()
    {
        //TODO : Signaler qu'il faut décompter une box en moins
        BoxManager.InstanceBoxManager.ABoxIsDestroyed();
        Destroy(gameObject);
        
    }
}
