using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0;
    private void OnCollisionEnter(Collision other) {
        hit++;
        Debug.Log("You've bumped into a thing this many times :" + hit);
    }
}
