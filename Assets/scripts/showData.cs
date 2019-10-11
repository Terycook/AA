using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelLivesText;
    public Text PanelSpeedText;
    public Text PanelScoreText;
    public Text PanelHighscoreText;
    public Text PanelRoundsPlayedText;

    private void Awake()
    {
        PanelNameText.text = "Name: " + KeepData.PlayerName;
        PanelLivesText.text = "Lives: " + KeepData.PlayerLives.ToString();
        PanelSpeedText.text = "Speed: " + KeepData.PlayerSpeed.ToString();
        PanelHighscoreText.text = "High Score: " + KeepData.HighScore.ToString();
        PanelRoundsPlayedText.text = "Rounds Played: " + KeepData.RoundsPlayed.ToString();


    }

    private void Update()
    {
        PanelScoreText.text = "Score: " + Score.PinCount.ToString();
    }
}
