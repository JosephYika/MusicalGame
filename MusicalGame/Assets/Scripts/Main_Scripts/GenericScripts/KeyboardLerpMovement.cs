/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardLerpMovement : MonoBehaviour
{
    #region Variables

    public Vector3 endPosition; // end position for the linear interpolation  ( the point to which the keyboard is being moved  )
    public List<Vector3> endPositions; // list for all of the end positions between which the keyboard will be moved 
    private Vector3 startPosition;  // the start position of the keyboard 
    private float desiredDuration = 4f; // the duration of the linear interpolation 
    private float elapsedTime; // the time that the disredDuration will be divided by 
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        endPositions = new List<Vector3>(); // create a list of end positions 
        endPositions.Add(new Vector3(-16.5f, -0.1688532f, 0));     // determine coordinates of the ends positions 
        endPositions.Add(new Vector3(-12.5f, -0.1688532f, 0));       
        endPositions.Add(new Vector3(-8.5f, -0.1688532f, 0));
        endPositions.Add(new Vector3(-4.5f, -0.1688532f, 0));        
        endPositions.Add(new Vector3(-2.5f, -0.1688532f, 0));     
        endPositions.Add(new Vector3(1.5f, -0.1688532f, 0));


    }

    // Update is called once per frame
    void Update()
    {

       
    }

    /// <summary>
    /// 
    /// Moves the keyboard to the position on the x axis 
    /// </summary>
    public void MovetoNextPosition()
    {
       
     // Debug.Log(transform.position.x + ": Position X ");
        startPosition = transform.position;  // assign a new keyboard position to the start positions 
        elapsedTime = elapsedTime + Time.deltaTime; // calculate the elapsedTime with delta 
        float newTime = elapsedTime / desiredDuration;  // calculate the desired time 
        endPosition = endPositions[Random.Range(0, 5)]; // assign a random end positions to the current end positions 

        // check whether the keyboard is at a certain distance from the end positions ( to ensure that the position of the keyboard is being checked every frame at that distance 
        // so that there aren't any glitches)
        while (transform.position.x < endPosition.x - 0.01 || transform.position.x > endPosition.x + 0.01) 
        {
            startPosition = transform.position;             // assing new keyboard position 
            transform.position = Vector3.Lerp(startPosition,endPosition, newTime); // calculate a new position based on linear interpolation function 
        }
        
    }

    #endregion
}
