/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    #region Variables
    /// <summary>
    ///  Audio Sources for playing the sound between the tutorial scenes as well as for start menu and pre-gameplay 
    ///  They are public variable that have physical objects attached to them. 
    /// 
    /// </summary>
    public AudioSource playPopSound;
    public AudioSource playPianoMusic;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        SceneTransitionOnTrigger(); // trigger the function for changing between the scenes 
    }

    /// <summary>
    /// This functions allows to change between different scenes i.e. tutorials for all the levels 
    /// Every time a scene loads a sound is played to indicate the scene change 
    /// 
    /// </summary>
    public void SceneTransitionOnTrigger()
    {
        
        // LEVEL 1 
        // SCENE 0
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene0")) // check for the current (in the game ) scene 
        {
            if (Input.GetKeyDown(KeyCode.RightArrow)) // check if a user pressed right arrow 
            {
                SceneManager.LoadScene("TutorialScene1"); // change to a given scene 
                playPopSound.Play(); // play the sound from the audio source 
            }



        }
        // SCENE 1
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene1"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene2");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene0");
            }

        }
        // SCENE 2
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene2"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene3");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene1");
            }

        }

        // SCENE 3
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene3"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene4");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene2");
            }

        }

        // SCENE 4

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene4"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene5");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene3");
            }

        }

        // SCENE 5

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene5"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene6");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene4");
            }

        }

        // SCENE 6 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene6"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene7");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene5");
            }

        }

        // SCENE 7 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene7"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene8");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene6");
            }

        }

        // SCENE 8
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene8"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene9");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene7");
            }

        }

        // SCENE 9 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene9"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene10");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene8");
            }

        }

        // SCENE 10 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene10"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene11");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene9");
            }

        }

        // SCENE 11 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene11"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene12");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene10");
            }

        }

        // SCENE 12 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene12"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene13");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene11");
            }

        }

        // SCENE 13 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene13"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene14");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene12");
            }

        }

        // SCENE 14 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene14"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene15");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene13");
            }

        }

        // SCENE 15 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene15"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene16");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene14");
            }

        }

        // SCENE 16 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene16"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene17");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene15");
            }

        }

        // SCENE 17 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene17"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                playPianoMusic.Play();
                SceneManager.LoadScene("Level1_IntermediaryModeWhite");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene16");
            }

        }


        // LEVEL 2 

        // LEVEl2_SCENE 0 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene0"))
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene1");
                playPopSound.Play();
            }



        }

        // LEVEl2_SCENE 1 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene1"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene2");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene0");
            }

        }
        // LEVEl2_SCENE 2

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene2"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene3");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene1");
            }

        }

        // LEVEl2_SCENE 3


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene3"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene4");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene2");
            }


        }

        // LEVEl2_SCENE 4

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene4"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene5");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene3");
            }

        }
        // LEVEl2_SCENE 5



        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene5"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene6");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene4");
            }

        }

        // Level2_Scene6

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene6"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene7");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene5");
            }

        }

        // Level2_Scene7

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene7"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene8");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene6");
            }

        }

        // Level2_Scene8

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene8"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene9");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene7");
            }

        }
        // Level2_Scene9

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene9"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene10");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene8");
            }

        }
        // Level2_Scene10

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene10"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene11");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene9");
            }

        }

        // Level2_Scene11

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene11"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene12");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene10");
            }

        }

        // Level2_Scene12

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene12"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene13");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene11");
            }

        }

        // Level2_Scene13

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene13"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene14");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene12");
            }

        }

        // Level2_Scene14

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene14"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene15");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene13");
            }

        }

        // Level2_Scene15
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene15"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene16");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene14");
            }

        }

        // Level2_Scene16
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene16"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene17");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene15");
            }

        }

        // Level2_Scene17
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene17"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene18");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene16");
            }

        }
        // Level2_Scene18
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene18"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene19");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene17");
            }

        }
        // Level2_Scene19
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene19"))
        {


            // Exit Tutorial 
            // OR
            // COntinue to 2nd interval 


        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Start2nd"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene20");
            }





        }


        // Level2_Scene20
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene20"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene21");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Start2nd");
            }

        }



        // Level2_Scene21
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene21"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene22");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene20");
            }

        }

        // Level2_Scene22
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene22"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene23");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene21");
            }

        }

        // Level2_Scene23
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene23"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene24");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene22");
            }

        }
        // Level2_Scene24
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene24"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene25");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene23");
            }

        }
        // Level2_Scene25
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene25"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene26");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene24");
            }

        }
        // Level2_Scene26
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene26"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial_Scene27");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Scene25");
            }

        }
        // Level2_Scene27
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Scene27"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Mode1");
            }



        }

        // LEVEL2 INTERVALS 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode1") && ScoreBoardStatic.ScoreAPoint == 2) // 30
        {



            playPopSound.Play();
            SceneManager.LoadScene("Level2_Mode1_Faster");




        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode1_Faster") && ScoreBoardStatic.ScoreAPoint == 2) // 20
        {



            playPopSound.Play();
            SceneManager.LoadScene("Level2_Mode2");




        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode2_Faster") && ScoreBoardStatic.ScoreAPoint == 2) // 20
        {



            playPopSound.Play();
            SceneManager.LoadScene("Level2_Mode3");




        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3") && ScoreBoardStatic.ScoreAPoint == 2) // 20
        {



            playPopSound.Play();
            SceneManager.LoadScene("Level2_Mode3_Faster");




        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3_Faster") && ScoreBoardStatic.ScoreAPoint == 2) // 20
        {



            playPopSound.Play();
            SceneManager.LoadScene("Level2_Congratulations");




        }


        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Congratulations") && ScoreBoardStatic.ScoreAPoint == 2) // 20
        //{



        //    playPopSound.Play();
        //    SceneManager.LoadScene("Main_Menu");




        //}


        // LEVEL 2 MAJOR AND MINOR 3rd 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3_Mode0Major") && ScoreBoardStatic.ScoreAPoint == 3) //20
        {

            SceneManager.LoadScene("CongratulationsMenu");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3_Mode1Minor") && ScoreBoardStatic.ScoreAPoint == 3) //20
        {

            SceneManager.LoadScene("CongratulationsMenu");

        }


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial_Start3rd"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial3rd_1");
            }



        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial3rd_1"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial3rd_2");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial_Start3rd");
            }



        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial3rd_2"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial3rd_3");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial3rd_1");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial3rd_3"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Mode2");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial3rd_2");
            }


        }


        // Level2 Perfect 4th 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial4th_0"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial4th_1");
            }



        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial4th_1"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial4th_2");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial4th_0");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial4th_2"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial4th_3");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial4th_1");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial4th_3"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial4th_4");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial4th_2");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial4th_4"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial4th_5");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial4th_3");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial4th_5"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Tutorial4th_6");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial4th_4");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Tutorial4th_6"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level2_Mode3");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Level2_Tutorial4th_5");
            }


        }


        // LEVEL 3 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_0"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_1");
            }



        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_1"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_2");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_0");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_2"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_3");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_1");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_3"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_4");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_2");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_4"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_5");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_3");
            }


        }



        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_5"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_6");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_4");
            }


        }

        // major chords 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_6"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_7");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_5");
            }


        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_7"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_8");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_6");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_8"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_9");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_7");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_9"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_10");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_8");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_10"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_17");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_9");
            }

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_17"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level3_MajorChordStart");
            }



        }


        // minor chords

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_11"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_12");
            }



        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_12"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_13");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_11");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_13"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_14");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_12");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_14"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_15");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_13");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_15"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialLevel3_16");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_14");
            }


        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialLevel3_16"))
        {


            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level3_MinorChordStart");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialLevel3_15");
            }

        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3_MinorChordStart"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level3_Mode1Minor");
            }

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3_MajorChordStart"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("Level3_Mode0Major");
            }

        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartMenu");
        }
    }
        #endregion
    }
