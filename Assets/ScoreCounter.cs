using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scorecount;

    // Start is called before the first frame update
    void Start()
    {
        scorecount.text = "Score: " + Breakable.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scorecount.text = "Score: " + Breakable.score.ToString();
    }
}
