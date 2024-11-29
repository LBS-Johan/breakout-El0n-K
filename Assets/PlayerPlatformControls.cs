using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformControls : MonoBehaviour
{
    public int speed;
    Rigidbody2D rigidbody2D;
 
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector2(-0.1f, 0);
        }
    }
}
