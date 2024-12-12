using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformControls : MonoBehaviour
{
    public int speed;
    Rigidbody2D rigidbody2D;
 
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigidbody2D.velocity = new Vector3();

        if (Input.GetKey(KeyCode.A)&& transform.position.x > -9)
        {
            rigidbody2D.velocity = new Vector3(-1, 0) * speed;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 9)
        {
            rigidbody2D.velocity = new Vector3(1, 0) * speed;
        }
        
    }   
}
