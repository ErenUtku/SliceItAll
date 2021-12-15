using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public Text multiplierText;
    public Text scoreText;
    public Text txtmultipleScore;
    public int value;
    private int totalscore;
    public ScoreCounter scoreCounter;
    private int multipleScore;

    void Start()
    {
        Time.timeScale = 1;
        totalscore = scoreCounter.GetComponent<ScoreCounter>().scoreCounter;
    }
  
    void Update()
    {
        multiplierText.text = value.ToString();
        scoreText.text = totalscore.ToString();
        multipleScore = value * totalscore;
        txtmultipleScore.text = multipleScore.ToString();
    }
    public void SendValue(int value)
    {
        Time.timeScale = 0;
        this.value = value;
    }

    public void NextLevel()
    {
        int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex; ;
        SceneManager.LoadScene(sceneBuildIndex+1);
    }
}
