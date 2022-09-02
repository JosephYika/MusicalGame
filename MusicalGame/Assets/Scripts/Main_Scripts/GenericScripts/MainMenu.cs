/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Main Menu Class 
/// This class contains functions that trigger a view scene in the Main Menu scene i.e. after pressing a specific button a different view is displayed such as sub-menu 
/// </summary>
public class MainMenu : MonoBehaviour
{
    // change to tutorial Level 1
    public void Play()
    {
        SceneManager.LoadScene("TutorialScene0"); // load a passed scene 
    }
    // Quit the game 
    public void Quit()
    {
        Application.Quit();
    }

    // Play Level 1
    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1_IntermediaryModeWhite");
    }
    public void LearnLevel1()
    {
        SceneManager.LoadScene("TutorialScene0");
    }


    // Interval Secion for Tutorials 

    public void Basics()
    {
        SceneManager.LoadScene("Level2_Tutorial_Scene0");
    }

    public void SecondInterval()
    {
        SceneManager.LoadScene("Level2_Tutorial_Start2nd");
    }
    public void ThirdInterval()
    {
        SceneManager.LoadScene("Level2_Tutorial_Start3rd");
    }
    public void FourthInterval()
    {
        SceneManager.LoadScene("Level2_Tutorial4th_0");
    }

    // Interval Section for Gameplay 

    public void Load2nd()
    {
        SceneManager.LoadScene("Level2_Tutorial_Scene27");
    }
    public void Load3rd()
    {
        SceneManager.LoadScene("Level2_Tutorial3rd_3");
    }
    public void Load4th()
    {
        SceneManager.LoadScene("Level2_Tutorial4th_6");
    }

    public void LoadChords()
    {
        SceneManager.LoadScene("Level3_Mode0");
    }


   // Keys Section for gameplay 

    public void LoadLevel1_Mode10()
    {
        SceneManager.LoadScene("Level1_Mode10");
    }

    public void LoadLevel1_IntermediaryModeWhite()
    {
        SceneManager.LoadScene("Level1_IntermediaryModeWhite");
    }
    public void LoadLevel1_Mode8_Slow()
    {
        SceneManager.LoadScene("Level1_Mode8_Slow");
    }

    public void LoadLevel1_Mode10_White_Slow()
    {
        SceneManager.LoadScene("Level1_Mode10_White_Slow");
    }

    public void LoadLevel1_IntermediaryModeBlack()
    {
        SceneManager.LoadScene("Level1_IntermediaryModeBlack");
    }

    public void LoadLevel1_Mode9_Slow()
    {
        SceneManager.LoadScene("Level1_Mode9_Slow");
    }

    public void LoadLevel1Mode10_Black_Slow()
    {
        SceneManager.LoadScene("Level1_Mode10_Black_Slow");
    }


    // CHORDS
    public void LoadChordBasics()
    {
        SceneManager.LoadScene("TutorialLevel3_0");
    }
    public void LoadChordMajorTutorial()
    {
        SceneManager.LoadScene("TutorialLevel3_6");
    }
    public void LoadChordMinorTutorial()
    {
        SceneManager.LoadScene("TutorialLevel3_11");
    }

    public void LoadChordMajorGameplay()
    {
        SceneManager.LoadScene("Level3_MajorChordStart");
    }
    public void LoadChordMinorGameplay()
    {
        SceneManager.LoadScene("Level3_MinorChordStart");
    }


}
