/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Level2_SpawnerNonStatic : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys; // notes array 
    private GameObject note; // actual note from the spawner 
    public GameObject Note { get => note; }  // returns an actual note so that I can use it in any other script I want -- I can access it this way 
    public float notePos; // reference to the position of the note 
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        
        GenerateFirstNote(); // generate first note -- see below Generate FIrst Key function 

    }

    // Update is called once per frame
    void Update()
    {
        // check the position of note while below - 2.9 -- this is done to ensure that the position of the note is being check at a certain distance 
        // to avoid any sort of glitches 
        if(note.transform.position.y < -2.9)
        {
            notePos = note.transform.position.x;
        }
    }


    /// <summary>
    /// Generate the first note from the spawner 
    /// </summary>
    /// <returns></returns>
    public GameObject GenerateFirstNote()
    {
        var index = UnityEngine.Random.Range(0, Keys.Length); // select a random element and assign to index variable 
        
        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name); // calculate position of the note that the element from the array corresponds to 
        var vector2D = new Vector2(posX, transform.position.y);  // calculate the new position 
        transform.position = vector2D; // update the position accordingly 

        // Instantiate key on corresponding position
        return note = Instantiate(Keys[index], transform.position, Quaternion.identity);
    }

    /// <summary>
    /// Generates new note on the screen 
    /// </summary>
    /// <returns></returns>
    public GameObject GenerateNewNote()
    {
        DestroyNote();
        //Generate index for 'key' to instantiate
        var index = UnityEngine.Random.Range(0, Keys.Length);  // select a random element and assign to index variable 

        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name); // calculate position of the note that the element from the array corresponds to 
        var vector2D = new Vector2(posX, transform.position.y); // calculate the new position 
        transform.position = vector2D; // update the position accordingly 

        note = Instantiate(Keys[index], vector2D, Quaternion.identity); // instantiate new note 
        SynchronizeNotes(); // synchronize the note 
        return note; // return the note 
    }

    /// <summary>
    /// Replaces the current note that was moved left or right with a new note ( the note new note is generated where the previous note moved to ) 
    /// </summary>
    /// <param name="noteName"></param>
    /// <param name="position"></param>
    /// <returns></returns>
    public GameObject ReplaceExistingNote(string noteName, Vector2 position)
    {
        // Destroy existing key
        DestroyNote(); // destroy the first note 
        
        var tempNote = Keys.FirstOrDefault(x => x.name == noteName);  // FirstOrDefault Returns the first element of a sequence, or a specified default value if the sequence contains no elements i.e. returns the note, based on the name of the note 

        if (tempNote == null) // check whether the note is null 
        {
            tempNote = Keys[0]; // assign a new note 
        }

        // Instantiate specific key on a given position
        var targetPos = new Vector2(position.x, transform.position.y); // calculate new target positions 
        transform.position = targetPos; // updated the transform position of the note 
        note = Instantiate(tempNote, position, Quaternion.identity); // instantiate the note 
        SynchronizeNotes(); // synchronize note
        return note; // return the note 
    }

    public void DestroyNote()
    {
        // Check if key is already destroyed 
        // If destroyed:  do nothing, if not: destroy it
        if (note == null)
        {
            return;
        }

        notePos = note.transform.position.x; // assign new x position 
        Destroy(note);
        note = null;
    }

    /// <summary>
    /// Synchornizes notes together -- called after the note is moved (see MovementControlNonStatic ) 
    /// </summary>
    void SynchronizeNotes()
    {
        var staticSpawner = FindObjectOfType(typeof(Level2_SpawnerStatic)); // get a reference to the static spawner 
        //var nonStaticNote = FindObjectOfType<Level2_MovementControlNonStatic>().gameObject;
        if (staticSpawner == null)
        {
          //  Debug.Log(" nonStaticNote == null");
        }

        if (note == null)
        {
         //   Debug.Log(" note == null");
        }

        // check whether static spawner is null or not doesn't exist 
        if (staticSpawner == null || note == null)
        {
            return;
        }
        var staticNote = ((Level2_SpawnerStatic)staticSpawner).Note; // get a note from the static spawner 
        if (staticNote == null)
        {
            return;
        }
        /*
         * The Math. abs() function returns the absolute value of a number. That is, it returns x if x is positive or zero, and the negation of x if x is negative.
         * i.e. this returns the opposite of whatever the number will be from the calculation -- whatever the position of the note on the y axis will be 
         */
        var diff = Mathf.Abs(staticNote.transform.position.y - note.transform.position.y); // check the positions of the static note on the y axis 

        // check the new y position at a certain distance 
        if (diff > (float)0.01 && diff < 5)
        {
            //Debug.Log("------------BEFORE------------}");
            //Debug.Log($"nonstatic y: {staticNote.transform.position.y}\n\t         static   y: {note.transform.position.y}");
            //Debug.Log("------------BEFORE------------}");


            // check the y position of the note from the static spawner 
            if (staticNote.transform.position.y > note.transform.position.y)
            {
              //  Debug.Log($"{note.name}  wyzej niz {staticNote.name}. Przesuwanie {staticNote.name} w gore");
                var newPost = new Vector2(note.transform.position.x, staticNote.transform.position.y);
                note.transform.position = newPost;
            }
            else
            {
             //   Debug.Log($"{staticNote.name} higher than  {note.name}. Moving {note.name} up");
                var newPost = new Vector2(staticNote.transform.position.x, note.transform.position.y);
                staticNote.transform.position = newPost;
            }

            //Debug.Log("------------AFTER------------}");
            //Debug.Log($"nonstatic y: {staticNote.transform.position.y}\n\t         static   y: {note.transform.position.y}");
            //Debug.Log("------------AFTER------------}");
        }
    }

    #endregion
}