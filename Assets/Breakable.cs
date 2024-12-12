using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public static int score;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(health == 0)
        {
            Destroy(gameObject);
            score += 1;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        health -= 1;
    }
}
