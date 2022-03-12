using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;
   [SerializeField] float timeToWait = 5.0f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            Debug.Log("Time passed: " + timeToWait);
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
