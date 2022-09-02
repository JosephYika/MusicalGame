/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControlParent : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos; // the target position of the note
    public float XIncrement; // how many blocks the note is moving left and right -- this will be set two 2 blocks 


    public float speed; // speed of the note 


    public float maximumX_Positive; // limit on the x positive axis for the note i.e. the note can't move more than whatever will this variable data be e.g. 9 
    public float minimumX_Negative; // limit on the x negative axis for the note, i.e. the note can't move more than whatever will this variable data be e.g. -9

    //private float previousTime;
    //public float fallTime = 0.8f;

    public float respawnTime = 4.0f; // the time that it takes the note to respawn 

    private GameObject _note; // reference to the actual note 
    private KeyboardLerpMovement move; // reference to the keyboardlerpmovement class 

    

    
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        // reference to the keyboard lerp movement class -- this way i can acess all of the class behaviour 
        move = FindObjectOfType<KeyboardLerpMovement>();
        
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
        // check which note collided ( See GenericScript -- alternatevily click on the CompareTagsExenstion while holding CTRL on the keyboard) 
        if (pianoKey.CompareTagsExtension()) 
        {
            // get a reference to an actual note from the spawner 
            _note = GameObject.FindObjectOfType<SpawnerParent>().Note;
            
            if(_note != null) // it the note isn't null
            {

                Destroy(_note); // destroy the note 

            }
            
            move.MovetoNextPosition(); // move the keyboard 
         //   Debug.Log("Move Position triggered");
            
            
        }
        

  
    }

    


    #endregion
}

// Extension for checking whether the note hit the specific key 
