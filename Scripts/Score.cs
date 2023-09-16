using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int imunitate = 0;
    private static int anticorpi = 0;
    public GameObject GameOver;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        imunitate = 0;
    }

    void Update()
    {
        scoreText.text = "Score (IgM) : " + imunitate;
        highScoreText.text = "High Score (IgG) : " + anticorpi;
        if (imunitate > anticorpi)
        {
            anticorpi = imunitate;
        }
        
        if (GameOver != null && imunitate < 0)
        {
            Time.timeScale = 0;
            GameOver.SetActive(true);
        }
    }
}
