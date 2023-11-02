using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int kill = 0;

    [SerializeField] TextMeshProUGUI killText;
    [SerializeField] GameObject gameOverText;

    Boolean gameOver = false;

    private void Awake()
    {
        instance = this;
    }
    public void IncreaseKills (int amount)
    {
        kill += amount;
        killText.text = "Kills: " + kill;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.SetActive(true);


    }
}