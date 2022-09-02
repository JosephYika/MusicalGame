/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    #region Variables
    public static bool isPaused = false;  // variable that indicates whether the game is paused 
    public GameObject userInterfacePanel; // accessing a user interfaces created in Unity 
    #endregion

    #region Unity Methods
	
    
    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.Space)) // check if a user pressed space on the keyboard 
        {
            if(isPaused == true) // check whether the current state of the game is paused
            {
                Resume(); // Resume 
            }
            else
            {
                PauseTheGame(); // Or pause a game 
            }
        }
       
    }


    /// <summary>
    /// Resume allows to resume the game 
    /// </summary>
    public void Resume()
    {
        userInterfacePanel.SetActive(false); // disable the pause game menu 
        Time.timeScale = 1f; // restart the real game time 
        isPaused = false; // update the state of the game ( not paused )
    }
    /// <summary>
    /// Pauses the game 
    /// </summary>
    public void PauseTheGame()
    {
        userInterfacePanel.SetActive(true); // enable the pause game menu 
        Time.timeScale = 0f; // freeze the real game time 
        isPaused = true; // update the state of the game to be paused 
    }

    /// <summary>
    /// Loads Start Menu 
    /// </summary>
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    
    #endregion
}
