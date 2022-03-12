using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0;//0.01f;
    [SerializeField] float zValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions(){
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer(){
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue,yValue,zValue);
    }
}
