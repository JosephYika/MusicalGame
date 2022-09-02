/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class Spawner for Spawning Notes 
/// </summary>
public class SpawnerParent : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys; // the array of notes -- all of the prefab notes go here 
    public static int generateKeys; // variable for generating notes from the spawner

    private GameObject _note; // reference to the actual note within a scene 
    public GameObject Note { get { return _note; } } // get a reference to the note and return it , this way I can access it in the other class 

    
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _note = NewKeys();// called New Keys methods --- see below 

    }

    // Update is called once per frame
    void Update()
    {
        // check whether the note is null , if it is then generate  a new note -- see New Keys function below 
        if(_note == null)
        {
            _note = NewKeys();
        }
        
    }

    /// <summary>
    /// Generates NOTES from the spawner 
    /// </summary>
    public GameObject NewKeys()
    {
        // Debug.Log($"Nuta = {generateKeys} zostala wygenerowana");

        // generate notes from the array -- from the spawner in order from the first to the last elenment 
        return Instantiate(Keys[generateKeys++ % Keys.Length], transform.position, Quaternion.identity);


    }


    #endregion
}
