using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update

   [SerializeField] float timeToWait = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            Debug.Log("Time passed: " + timeToWait);
        }
    }
}
