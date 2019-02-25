using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //UI
    public Text ScoreText;
    public Text TimerText;
    public Text HighScoreText;

    //constants 
    private const string PLAYER_PREF_HIGHSCORE = "highScore";
    private const string FILE_HIGH_SCORE = "/HighScoreFile.txt";

    //Timer
    private float timer;
    public float Timer
    {
        get { return timer; }
        set
        {
            timer = value;
            TimerText.text = "Time: "+ timer+"s";
        }
    }
    private float TimeLimit;
    
    //Score
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
            HighScore = score;
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
                //PlayerPrefs.SetInt(PLAYER_PREF_HIGHSCORE,HighScore);

                string fullPathToFile = Application.dataPath + FILE_HIGH_SCORE;
                
                File.WriteAllText(fullPathToFile,"High Score: " + HighScore);
                Debug.Log("The save file exists!");
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

        Score = 0;
        //HighScore = PlayerPrefs.GetInt(PLAYER_PREF_HIGHSCORE,10);
        
        string highScoreFileText = File.ReadAllText(Application.dataPath + FILE_HIGH_SCORE);
        string[] scoreSplit = highScoreFileText.Split(' ');
        //Debug.Log(scoreSplit[2]);
        HighScore = Int32.Parse(scoreSplit[2]);
    }


    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > TimeLimit)
        {
            _GameOver();
        }
            
    }

    void _GameOver()
    {
        //do game over things
    }
}
