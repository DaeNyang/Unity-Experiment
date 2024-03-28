using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    [SerializeField]float moveSpeed = 20f , steerSpeed = 1f;    //[SreializeField] == unity에 변수를 변경 가능한 창을 띄워줌
    [SerializeField] float verySlowSpeed = 5f, slowSpeed = 15f , boostSpeed = 30f;
   
    void Update()
    {   
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "B")
        {
            moveSpeed = boostSpeed;
        }

        if(other.tag == "S")
        {
            moveSpeed = verySlowSpeed;
        }

        if(other.tag =="Move")
        {
            moveSpeed = 20f;
        }

    }
}
