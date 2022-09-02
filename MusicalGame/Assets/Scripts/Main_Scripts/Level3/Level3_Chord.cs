/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Level3_Chord : MonoBehaviour
{
    public GenericScript.Interval intervalEnum;
    public GenericScript.Chord chordEnum;

    public TextMeshProUGUI chordText;

    private Level3_SpawnerStatic noteReference;

    private Level3_SpawnerStatic2nd noteReferenceSecondStaticSpawner;




    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {


        noteReference = FindObjectOfType<Level3_SpawnerStatic>();
        noteReferenceSecondStaticSpawner = FindObjectOfType<Level3_SpawnerStatic2nd>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateNewChordOnTheScreen()
    {
        // Adding boundaries - if the spawned notes are C and C# generate only Minor 2nd or Major Second Interval UP , not down. There is not enough space to build it down..
        // Accordingly If its B or A Sharp then an Interval will only indacte to build it down. 

        // Major and Minor 2nds 
        if (noteReference.Note.tag == "C")
        {

            List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
            chords.Add(GenericScript.Chord.C_MajorUp);
            

            var chordPick = Random.Range(0, chords.Count);
            chordEnum = chords[chordPick];


        }
        else if (noteReference.Note.tag == "D")
        {
            List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
            chords.Add(GenericScript.Chord.D_MajorUp);


            var chordPick = Random.Range(0, chords.Count);
            chordEnum = chords[chordPick];
        }
        else if (noteReference.Note.tag == "E")
        {
            List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
            chords.Add(GenericScript.Chord.E_MajorUp);


            var chordPick = Random.Range(0, chords.Count);
            chordEnum = chords[chordPick];
        }
        else if (noteReference.Note.tag == "CSharp")
        {
            List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
            chords.Add(GenericScript.Chord.CSharp_MajorUp);


            var chordPick = Random.Range(0, chords.Count);
            chordEnum = chords[chordPick];
        }
        else if (noteReference.Note.tag == "DSharp")
        {
            List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
            chords.Add(GenericScript.Chord.DShapr_MajorUp);


            var chordPick = Random.Range(0, chords.Count);
            chordEnum = chords[chordPick];
        }


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3_Mode1Minor"))
        {
            if (noteReference.Note.tag == "C")
            {

                List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
                chords.Add(GenericScript.Chord.C_MinorUp);


                var chordPick = Random.Range(0, chords.Count);
                chordEnum = chords[chordPick];


            }
            else if (noteReference.Note.tag == "D")
            {
                List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
                chords.Add(GenericScript.Chord.D_MinorUp);


                var chordPick = Random.Range(0, chords.Count);
                chordEnum = chords[chordPick];
            }
            else if (noteReference.Note.tag == "E")
            {
                List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
                chords.Add(GenericScript.Chord.E_MinorUp);


                var chordPick = Random.Range(0, chords.Count);
                chordEnum = chords[chordPick];
            }
            else if (noteReference.Note.tag == "DSharp")
            {
                List<GenericScript.Chord> chords = new List<GenericScript.Chord>();
                chords.Add(GenericScript.Chord.DSharp_MinorUp);


                var chordPick = Random.Range(0, chords.Count);
                chordEnum = chords[chordPick];
            }
        }





            chordText.text = GenericScript.ChordChange(chordEnum);
    }


    #endregion
}
