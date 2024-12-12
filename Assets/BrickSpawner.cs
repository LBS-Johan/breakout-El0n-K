using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBrickSpawner : MonoBehaviour
{
    public float yPosition;
    public float brickXposition;
    public GameObject brick;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 19; i++)
        {
            Instantiate(brick, new Vector2(brickXposition, yPosition), Quaternion.identity);
            brickXposition += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
