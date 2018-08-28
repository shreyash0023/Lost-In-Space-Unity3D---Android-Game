using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    private int now = 3;
    private int score = 0;
    //public GUIText scoreLabel;
    
    void Start()
    {
        //scoreLabel.text = score.ToString();
        scoreText.text = score.ToString();
    }

    void Update()
    {
        InvokeRepeating("AdToScore", 0, 10);
    }

    void AdToScore()
    {
        if (now > 0)
        {
            score = score + 1;
            scoreText.text = score.ToString();
        }
    }
}