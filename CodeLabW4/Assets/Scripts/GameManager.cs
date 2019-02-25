using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public Text TimerText;
    public Text HighScoreText;

    private float timer;
    
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            ScoreText.text = "Score: " + score;
            highScore = score;
        }
    }

    private int highScore;

    public int HighScore
    {
        get
        {
            return highScore;
        }
        set
        {
            if (value > highScore)
            {
                highScore = value;
                HighScoreText.text = "High Score: " + highScore;
            }
        }
    }

    public static GameManager instance;

    void Start()
    {
        //SINGLETON
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {
        timer += Time.deltaTime;
        if (timer < 0)
        {
            _GameOver();
        }
            
    }

    void _GameOver()
    {
        //do game over things
    }
}
