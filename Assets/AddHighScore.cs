using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHighScore : MonoBehaviour
{
    public static int highScore = 0;
    
    void Start()
    {

    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "High score :" + highScore.ToString();
    }

}
