using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int scoreCounter;

    [SerializeField] private Knife scored;

    private void Start()
    {
        scored.OnScore += Player_GetScore;
    }

    private void Player_GetScore(object sender, System.EventArgs e)
    {
        scoreCounter++;
    }
}
