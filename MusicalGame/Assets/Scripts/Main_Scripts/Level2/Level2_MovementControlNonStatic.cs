/*
 Copyright (c) Józef Yika
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Level2_MovementControlNonStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos; // the target position of the note
    public float XIncrement;  // how many blocks the note is moving left and right 
    public float velocity;
    public float speed;  // speed of the note

    public float maximumX_Positive; // limit on the x positive axis for the note i.e. the note can't move more than whatever will this variable data be e.g. 9 
    public float minimumX_Negative; // limit on the x negative axis for the note, i.e. the note can't move more than whatever will this variable data be e.g. -9

    public float fallTime = 0.8f;

    public float respawnTime = 4.0f; // the time that it takes the note to respawn 

    private Level2_SpawnerNonStatic _spawner; // reference to the static spawner 







    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
       
        _spawner = FindObjectOfType<Level2_SpawnerNonStatic>();  // accessing the behaviour of the non static spawner classes by assigning them to a local variable





    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime); // automatically move the note down as soon as the game starts

        var moved = false; // set moved to false by default 

        // check whether the user pressed the right or left arrow and check the x position of the note 
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumX_Positive)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true; // update the move status 
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumX_Negative)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true; // update the move status 
        }

        // if the moved was moved 
        if (moved)
        {
            _spawner.DestroyNote(); // destroy the previous note 
            var note = GenericScript.CalculateNoteNameFromPosition(transform.position.x, "Sharp"); // calculate the new note that should be placed in the new (moved) position
            _spawner.ReplaceExistingNote(note, transform.position); // replace the note -- see ReplaceExistingNote function by holding CTRL and CLICK 

            

            


        }



       
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
           
            
           
            _spawner.DestroyNote(); // destroy the note 
            
         //   Debug.Log("NON STATIC : NOTE DESTROYED"); 
            _spawner.GenerateNewNote(); // generate new note -- see GenerateNewNote definition by holding CTRL and click on it 
        }
        
        

    }

   

    #endregion
}