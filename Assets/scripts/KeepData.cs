
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//THIS SCRIPT IS ATTACHED TO THE DATA MANAGER OBJECT PRESENT IN All THE SCENES

public class KeepData : MonoBehaviour
{
    // STATIC so they are preserved between classes
    public static string PlayerName;
    public static int PlayerLives;
    public static int PlayerScore;
    public static int HighScore;
    public static float PlayerSpeed;
    public static int RoundsPlayed;

    public InputField PlayerNameInput;
    public Slider PlayerSpeedSlider;
    public Dropdown PlayerLivesDropdown;
    //lives are hard coded

    public Text showPlayerName; // don't forget to drop the hierarchy objects in the script slots in the inspector
    public Text showPlayerLives;
    public Text playingSpeedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }

    public void SetLives()
    {
        PlayerLives = PlayerLivesDropdown.value;
    }

    public void ChangeSpeed()
    {
        PlayerSpeed = PlayerSpeedSlider.value;
    }
}