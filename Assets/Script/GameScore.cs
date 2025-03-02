using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    Text scoreUI;
    int score;

    public int Score
    {
        get
        {
            return this.score;
        } 
        set
        {
            this.score = value;
            UpdateScoreUI();
        }
    }

    
    void Start()
    {
        scoreUI = GetComponent<Text>();
    }

    
    void UpdateScoreUI()
    {
        scoreUI.text = "" + score;
    }
}
