using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    [SerializeField] private float score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreTextEnd;
    [SerializeField] gameManager gameManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameManager.getGameOver())
        {
            score = score + Time.deltaTime;

            scoreText.text = "Score:" + (int)score;

            scoreTextEnd.text = "Score:" + (int)score;
        }
    }
}
