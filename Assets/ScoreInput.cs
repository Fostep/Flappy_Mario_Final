using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreInput : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore.score++;
        
        if(AddHighScore.highScore < AddScore.score)
        {
            AddHighScore.highScore = AddScore.score;
        }
    }
}
