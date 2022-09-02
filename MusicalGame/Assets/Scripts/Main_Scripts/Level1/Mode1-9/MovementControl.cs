/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    #region Variables

    
    private Vector2 targetPos; // the target position of the note 
    public float XIncrement; // how many blocks the note is moving left and right 

   // public float velocity;
    public float speed; // speed of the note 
    public float maxSpeed; // max speed of the note 
    
    
    public float maximumX_Positive; // limit on the x positive axis for the note i.e. the note can't move more than whatever will this variable data be e.g. 9 
    public float minimumX_Negative; // limit on the x negative axis for the note, i.e. the note can't move more than whatever will this variable data be e.g. -9

    //private float previousTime;
    //public float fallTime = 0.8f;

    public float respawnTime = 4.0f; // the time that it takes the note to respawn 

    private Spawner spawner; // reference for the spawner 
    
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(keyWave()); // start couroutine --- respawn notes every set number of seconds -- see keyWave function below at the bottom 
        
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = Vector2.MoveTowards(transform.position, targetPos, velocity * Time.deltaTime);

        
        transform.Translate(Vector2.down * speed * Time.deltaTime); // automatically move the note down as soon as the game starts 
        

        // Check whether the user pressed right or left arrows , check the limits on -x and +x axis and change the position of the note if all of the requirements have been met
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumX_Positive)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumX_Negative)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
        }



        
    }

    /// <summary>
    /// Check the note's collision with the key 
    /// </summary>
    /// <param name="pianoKey"></param>
    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if (pianoKey.CompareTagsExtension()) // check which note collided ( See GenericScript -- alternatevily click on the CompareTagsExenstion while holding CTRL on the keyboard) 
        {
            
            Destroy(gameObject); // destroy the note 
           // Debug.Log("The note is destroyed!"); 
        }

        



    }

    /// <summary>
    /// Waits for an assigned number of seconds before calling it again in the Start method
    /// </summary>
    /// <returns></returns>
    IEnumerator keyWave()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(respawnTime); // wait for a set number of seconds ( set in Unity ) 
            FindObjectOfType<Spawner>().NewKeys(); // generate a note from the spawner 
        }
    }

  


    #endregion
}


