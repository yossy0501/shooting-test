using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;

    public void GameOver()
    {
        this.gameOverText.GetComponent<UnityEngine.UI.Text>().text = "GameOver";
    }

    public void AddScore()
    {
        this.score += 10;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
    }

    void Update()
    {
        scoreText.GetComponent<UnityEngine.UI.Text>().text = "Score:" + score.ToString("D4");
    }
}
