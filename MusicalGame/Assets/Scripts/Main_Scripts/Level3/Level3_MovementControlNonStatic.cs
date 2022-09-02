/*
 Copyright (c) Józef Yika
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3_MovementControlNonStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    public float velocity;
    public float speed;

    public float maximumX_Positive;
    public float minimumX_Negative;

    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private Level3_SpawnerNonStatic _spawner;

    private float distanceBtwTwoNotes;
    private Level3_Chord chordText;

    private Level3_SpawnerStatic2nd checkPoint;
    private Level2_Score textScore;

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        textScore = FindObjectOfType<Level2_Score>();

        _spawner = FindObjectOfType<Level3_SpawnerNonStatic>();

        checkPoint = FindObjectOfType<Level3_SpawnerStatic2nd>();

        chordText = FindObjectOfType<Level3_Chord>();

        chordText.GenerateNewChordOnTheScreen();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        var moved = false;

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumX_Positive)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumX_Negative)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true;
        }


        if (moved)
        {
            _spawner.DestroyNote();
            var note = GenericScript.CalculateNoteNameFromPosition(transform.position.x, "Sharp");
            _spawner.ReplaceExistingNote(note, transform.position);






        }




    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if (pianoKey.CompareTagsExtension())
        {
            distanceBtwTwoNotes = checkPoint.notePos - transform.position.x ; // calculate the actual distance between two notes
     //       Debug.Log("Distance : " + distanceBtwTwoNotes.ToString("F1") + "units"); // log into console !

            Debug.Log("WCHODZIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII");
            if (distanceBtwTwoNotes == -6 && chordText.chordEnum == GenericScript.Chord.C_MajorUp)
            {

                ScoreBoardStatic.IncrementPoints();
       //         Debug.Log("Point ADDED FOR C MAJOR  UPPPPPPPPPPP W GOREEEE");


            }
            else if (distanceBtwTwoNotes == -4)
            {
                ScoreBoardStatic.IncrementPoints();
        //        Debug.Log("Point ADDED FOR D MAJOR  UPPPPPPPPPPP W GOREEEE");
            }
            else if (distanceBtwTwoNotes == -6  && chordText.chordEnum == GenericScript.Chord.E_MajorUp)
            {
                ScoreBoardStatic.IncrementPoints();
      //          Debug.Log("Point ADDED FOR E MAJOR  UPPPPPPPPPPP W GOREEEE");
            }
            else if (distanceBtwTwoNotes == -6 )
            {
                ScoreBoardStatic.IncrementPoints();
        //        Debug.Log("Point ADDED FOR C# MAJOR  UPPPPPPPPPPP W GOREEEE");
            }
            else if (distanceBtwTwoNotes == -6  && chordText.chordEnum == GenericScript.Chord.DShapr_MajorUp)
            {
                ScoreBoardStatic.IncrementPoints();
        //        Debug.Log("Point ADDED FOR D# MAJOR  UPPPPPPPPPPP W GOREEEE");
            }
            else if (ScoreBoardStatic.ScoreAPoint >= 1)
            {

                ScoreBoardStatic.DecrementPoints();

            }

            // MINOR CHORDS

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3_Mode1Minor"))
            {
                
                if (distanceBtwTwoNotes == -8 && chordText.chordEnum == GenericScript.Chord.C_MinorUp)
                {

                    ScoreBoardStatic.IncrementPoints();
         //           Debug.Log("Point ADDED FOR C Minor  UPPPPPPPPPPP W GOREEEE");


                }
                else if (distanceBtwTwoNotes == -8 && chordText.chordEnum == GenericScript.Chord.D_MinorUp)
                {
                    ScoreBoardStatic.IncrementPoints();
           //         Debug.Log("Point ADDED FOR D Minor  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == -8 && chordText.chordEnum == GenericScript.Chord.E_MinorUp)
                {
                    ScoreBoardStatic.IncrementPoints();
            //        Debug.Log("Point ADDED FOR E Minor UPPPPPPPPPPP W GOREEEE");
                }
   
                else if (distanceBtwTwoNotes == -8 && chordText.chordEnum == GenericScript.Chord.DSharp_MinorUp)
                {
                    ScoreBoardStatic.IncrementPoints();
          //          Debug.Log("Point ADDED FOR D# Minor  UPPPPPPPPPPP W GOREEEE");
                }
                else if (ScoreBoardStatic.ScoreAPoint >= 1)
                {
                   
                    ScoreBoardStatic.DecrementPoints();

                }
                textScore.scoreText.text = ScoreBoardStatic.ScoreAPoint.ToString();

            }


            textScore.scoreText.text = ScoreBoardStatic.ScoreAPoint.ToString();
       //     Debug.Log(" SCORE ========================================== " + ScoreBoardStatic.ScoreAPoint.ToString());


            _spawner.DestroyNote();

            //   Debug.Log("NON STATIC : NOTE DESTROYED"); 
            _spawner.GenerateNewNote();
        }



    }



    #endregion
}
