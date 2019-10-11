using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool GameHasEnded;

    public rotator Rotator;
    public spawner Spawner;

    public Animator animator;
    

    public void EndGame()
    {
        if(GameHasEnded)
            return;

        Rotator.enabled = false;
        Spawner.enabled = false;

        animator.SetTrigger("EndGame");
        

        GameHasEnded = true;
        
    }

    public void RestartLevel()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        KeepData.RoundsPlayed++;
    }
}
