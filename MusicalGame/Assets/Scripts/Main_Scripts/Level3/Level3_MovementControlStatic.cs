/*
 Copyright (c) Józef Yika
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3_MovementControlStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    public float velocity;
    public float speed;

    public float maximumX_Positive;
    public float minimumX_Negative;

    private float previousTime;
    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private Level3_SpawnerStatic _spawner;

    private Level3_SpawnerStatic2nd _spawnerSecond;
    private Level3_Chord chordText;

    private Level3_SpawnerNonStatic checkPoint; // a reference to the non static note

    private float distanceBtwTwoNotes; // distance between two notes 

    private Level2_Score textScore;

    

    


    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {

        chordText = FindObjectOfType<Level3_Chord>();
        _spawner = FindObjectOfType<Level3_SpawnerStatic>();
        chordText.GenerateNewChordOnTheScreen();
        checkPoint = FindObjectOfType<Level3_SpawnerNonStatic>();
        textScore = FindObjectOfType<Level2_Score>();
        _spawnerSecond = FindObjectOfType<Level3_SpawnerStatic2nd>();
        


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if (pianoKey.CompareTagsExtension())
        {
                // MAJOR CHORDS
          
            //    distanceBtwTwoNotes = transform.position.x - checkPoint.notePos; // calculate the actual distance between two notes
            //    Debug.Log("Distance : " + distanceBtwTwoNotes.ToString("F1") + "units"); // log into console !

            //    Debug.Log("WCHODZIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII");
            //    if (distanceBtwTwoNotes == -14 && chordText.chordEnum == GenericScript.Chord.C_MajorUp)
            //    {
                    
            //                ScoreBoardStatic.IncrementPoints();
            //                Debug.Log("Point ADDED FOR C MAJOR  UPPPPPPPPPPP W GOREEEE");
                         
                    
            //    }
            //    else if ((distanceBtwTwoNotes == 14) && chordText.chordEnum == GenericScript.Chord.D_MajorUp)
            //    {
            //        ScoreBoardStatic.IncrementPoints();
            //        Debug.Log("Point ADDED FOR D MAJOR  UPPPPPPPPPPP W GOREEEE");
            //    }
            //    else if ((distanceBtwTwoNotes == -4 && distanceBtwTwoNotes == -14) && chordText.chordEnum == GenericScript.Chord.E_MajorUp)
            //    {
            //        ScoreBoardStatic.IncrementPoints();
            //        Debug.Log("Point ADDED FOR E MAJOR  UPPPPPPPPPPP W GOREEEE");
            //    }
            //    else if ((distanceBtwTwoNotes == -4 && distanceBtwTwoNotes == -14) && chordText.chordEnum == GenericScript.Chord.CSharp_MajorUp)
            //    {
            //        ScoreBoardStatic.IncrementPoints();
            //        Debug.Log("Point ADDED FOR C# MAJOR  UPPPPPPPPPPP W GOREEEE");
            //    }
            //    else if ((distanceBtwTwoNotes == -4 && distanceBtwTwoNotes == -14) && chordText.chordEnum == GenericScript.Chord.DShapr_MajorUp)
            //    {
            //        ScoreBoardStatic.IncrementPoints();
            //        Debug.Log("Point ADDED FOR D# MAJOR  UPPPPPPPPPPP W GOREEEE");
            //    }
            //    else if (ScoreBoardStatic.ScoreAPoint >= 1)
            //    {

            //        ScoreBoardStatic.DecrementPoints();

            //    }
            





            //textScore.scoreText.text = ScoreBoardStatic.ScoreAPoint.ToString();
            //Debug.Log(" SCORE ========================================== " + ScoreBoardStatic.ScoreAPoint.ToString());
            _spawner.DestroyKey();
            _spawnerSecond.DestroyKey2();

            //   Debug.Log("NON STATIC : NOTE DESTROYED"); 
            _spawnerSecond.GenerateNewKey2();
            _spawner.GenerateNewKey();
            
        }
        chordText.GenerateNewChordOnTheScreen();


    }
    #endregion
  
}
