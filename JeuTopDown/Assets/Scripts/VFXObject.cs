using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXObject : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem _particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForDestroy(_particleSystem.main.duration));
    }

    IEnumerator WaitForDestroy(float duration)
    {
        yield return new WaitForSeconds(duration);
        Destroy(this);
    }
}
