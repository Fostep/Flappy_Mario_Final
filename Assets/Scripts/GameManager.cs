using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject canvas_gameOver;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        canvas_gameOver.SetActive(false);
        // canvas_gameOver = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
    }

    public void GameOver()
    {
        canvas_gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}


// GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();