/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Class Spawner for Spawning Notes 
/// </summary>
public class Spawner : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;  // the array of notes -- all of the prefab notes go here 
    public static int generateKeys; // variable for generating notes from the spawner 
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        NewKeys(); // called New Keys methods --- see below 
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /// <summary>
    /// Generates NOTES from the spawner 
    /// </summary>
    public void NewKeys() 
    {
        // Debug.Log($"Note = {generateKeys} has been generated"); 

        // generate notes from the array -- from the spawner in order from the first to the last elenment 
        Instantiate(Keys[generateKeys++ % Keys.Length], transform.position, Quaternion.identity); 
        
        
    }


    #endregion
}
