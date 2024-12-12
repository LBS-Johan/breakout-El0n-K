using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamageOutOfBounds : MonoBehaviour
{
    public int health;
    public GameObject ball;
    public TextMeshProUGUI healthCount;
    void Start()
    {
        healthCount.text = "Health: " + health;
    }

    
    void Update()
    {
        if(health == 0)
        {
            Destroy(ball);
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health -= 1;
        healthCount.text = "Health: " + health;
    }
}
