/*
 Copyright (c) Józef Yika
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level2_MovementControlStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos; // the target position of the note
    public float XIncrement; // how many blocks the note is moving left and right 

    public float velocity;
    public float speed;  // speed of the note

    public float maximumX_Positive; // limit on the x positive axis for the note i.e. the note can't move more than whatever will this variable data be e.g. 9 
    public float minimumX_Negative; // limit on the x negative axis for the note, i.e. the note can't move more than whatever will this variable data be e.g. -9

    //private float previousTime;
    //public float fallTime = 0.8f;

    public float respawnTime = 4.0f; // the time that it takes the note to respawn 

    private Level2_SpawnerStatic _spawner; // reference to the static spawner 

   
    private Level2_Interval intervalText; // reference to the Interval class

    private Level2_SpawnerNonStatic checkPoint; // a reference to the non static note

    public float distanceBtwTwoNotes; // distance between two notes 

    private Level2_Score textScore; // a reference to the Score class


    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        // accessing the behaviour of the interval and static spawner classes by assigning them to a local variables
        intervalText = FindObjectOfType<Level2_Interval>();
        _spawner = FindObjectOfType<Level2_SpawnerStatic>();

        intervalText.GenerateNewIntervalOnTheScreen(); // update the interval on the screen as soon as the game starts 

        // accessing the behaviour of the score ans non static spawner classes by assigning them to a local variables
        checkPoint = FindObjectOfType<Level2_SpawnerNonStatic>();
        textScore = FindObjectOfType<Level2_Score>();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime); // automatically move the note down as soon as the game starts

    }

    /// <summary>
    /// Check the note's collision with the key 
    /// </summary>
    /// <param name="pianoKey"></param>


    void OnTriggerEnter2D(Collider2D pianoKey)
    {
         // check which note collided ( See GenericScript -- alternatevily click on the CompareTagsExenstion while holding CTRL on the keyboard) 
        if (pianoKey.CompareTagsExtension())
        {

            // Check the current game scene and add points depending on the position of the note on the x axis  and the displayed interval on the screen 
            /*
             *  E.g. if the distance is -4 and the displayed interval is Major Second Up then add a point 
             *  or 
             *   if the distance is -4 and the displayed interval is Minor second Up then take away one point 
             *   
             *   
             * 
             */
            // MINOR AND MAJOR 2NDS
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode1_Faster"))
            {
                distanceBtwTwoNotes = transform.position.x - checkPoint.notePos; // calculate the actual distancec between two notes
            //    Debug.Log("Distance : " + distanceBtwTwoNotes.ToString("F1") + "units"); // log into console !

               
                if (distanceBtwTwoNotes == -4 && intervalText.intervalEnum == GenericScript.Interval.MajorSecondUp)
                {
                    ScoreBoardStatic.IncrementPoints();
          //          Debug.Log("Point ADDED FOR MAJOR SECOND  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 4 && intervalText.intervalEnum == GenericScript.Interval.MajorSecondDown)
                {
                    ScoreBoardStatic.IncrementPoints();
         //           Debug.Log("Point ADDED FOR MAJOR SECOND  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");

                }

                else if (distanceBtwTwoNotes == -2 && intervalText.intervalEnum == GenericScript.Interval.MinorSecondUp)
                {
                    ScoreBoardStatic.IncrementPoints();
           //         Debug.Log("Point ADDED FOR MINOR SECOND  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 2 && intervalText.intervalEnum == GenericScript.Interval.MinorSecondDown)
                {
                    ScoreBoardStatic.IncrementPoints();
          //          Debug.Log("Point ADDED FOR MINOR SECOND  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");
                }
                else if (ScoreBoardStatic.ScoreAPoint >= 1)
                {

                    ScoreBoardStatic.DecrementPoints();

                }
            }
                

            // MINOR AND MAJOR 3RDS
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode2_Faster"))
            {
                distanceBtwTwoNotes = transform.position.x - checkPoint.notePos; // calculate the actual distancec between two notes
                if (distanceBtwTwoNotes == -8 && intervalText.intervalEnum == GenericScript.Interval.MajorThirdUp)
                {
                    ScoreBoardStatic.IncrementPoints();
       //             Debug.Log("Point ADDED FOR MAJOR THIRD  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 8 && intervalText.intervalEnum == GenericScript.Interval.MajorThirdDown)
                {
                    ScoreBoardStatic.IncrementPoints();
       //             Debug.Log("Point ADDED FOR MAJOR THIRD  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");

                }

                else if (distanceBtwTwoNotes == -6 && intervalText.intervalEnum == GenericScript.Interval.MinorThirdUp)
                {
                    ScoreBoardStatic.IncrementPoints();
     //               Debug.Log("Point ADDED FOR MINOR THIRD  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 6 && intervalText.intervalEnum == GenericScript.Interval.MinorThirdDown)
                {
                    ScoreBoardStatic.IncrementPoints();
    //                Debug.Log("Point ADDED FOR MINOR THIRD  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");
                }
                else if (ScoreBoardStatic.ScoreAPoint >= 1)
                {

                    ScoreBoardStatic.DecrementPoints();

                }

            }

            // Perfect Fourth 

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3_Faster"))
            {

                distanceBtwTwoNotes = transform.position.x - checkPoint.notePos; // calculate the actual distancec between two notes
                if (distanceBtwTwoNotes == -10 && intervalText.intervalEnum == GenericScript.Interval.PerfectFourthUp)
                {
                    ScoreBoardStatic.IncrementPoints();
    //                Debug.Log("Point ADDED FOR FOURTH  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 10 && intervalText.intervalEnum == GenericScript.Interval.PerfectFourthDown)
                {
                    ScoreBoardStatic.IncrementPoints();
      //              Debug.Log("Point ADDED FOR FOURTH DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");

                }
                else if (ScoreBoardStatic.ScoreAPoint >= 1)
                {

                    ScoreBoardStatic.DecrementPoints();

                }
            }

             textScore.scoreText.text = ScoreBoardStatic.ScoreAPoint.ToString(); // update the score on the screen 
            _spawner.DestroyKey(); // destroy the note  

            //   Debug.Log("NON STATIC : NOTE DESTROYED"); 
            _spawner.GenerateNewKey(); // generate a new note 
        }
        intervalText.GenerateNewIntervalOnTheScreen(); // generate a new interval on the screen 


    }
    #endregion
}
