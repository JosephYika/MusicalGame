/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Level2_Interval : MonoBehaviour
{
    
    public GenericScript.Interval intervalEnum;  // accessing interval enum from the generic script 

    public TextMeshProUGUI IntervalText; // the interval that will be displayed 
    
    private Level2_SpawnerStatic noteReference; // reference to the static spawner 

   




    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        
       
        noteReference = FindObjectOfType<Level2_SpawnerStatic>(); // accesing the behviour from the static spawner by assigning it to the variable 

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Generates New Interval on the screen, based on: 
    /// 1. The note tag -- each object note has been assigned a tag in Unity that corresponds to its design 
    /// 2. The element from the enumerator 
    /// </summary>
    public void GenerateNewIntervalOnTheScreen()
    {
        // Adding boundaries - if the spawned notes are C and C# generate only Minor 2nd or Major Second Interval UP , not down. There is not enough space to build it down..
        // Accordingly If its B or A Sharp then an Interval will only indacte to build it down. 

        // Major and Minor 2nds 
        // check for the tag 
        if (noteReference.Note.tag == "C")
        {

            List<GenericScript.Interval> intervals = new List<GenericScript.Interval>(); // create list of type Interval ( enum ) 
            intervals.Add(GenericScript.Interval.MajorSecondUp); // add elements to the list 
            intervals.Add(GenericScript.Interval.MinorSecondUp);

            var intervalPick = Random.Range(0, intervals.Count); // make intervalPick interval hold a random element from the interavls list 
            intervalEnum = intervals[intervalPick]; // make intervalEnum hold that random element which in return will give an element from that Enum 
           
           
        }
        else if(noteReference.Note.tag == "CSharp")
        {
            List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
            intervals.Add(GenericScript.Interval.MajorSecondUp);
            intervals.Add(GenericScript.Interval.MinorSecondUp);
            intervals.Add(GenericScript.Interval.MinorSecondDown);

            var intervalPick = Random.Range(0, intervals.Count);
            intervalEnum = intervals[intervalPick];

        }
        else if(noteReference.Note.tag == "B")
        {
            List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
            intervals.Add(GenericScript.Interval.MajorSecondDown);
            intervals.Add(GenericScript.Interval.MinorSecondDown);

            var intervalPick = Random.Range(0, intervals.Count);
            intervalEnum = intervals[intervalPick];
        }
        else if (noteReference.Note.tag == "ASharp")
        {
            List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
            intervals.Add(GenericScript.Interval.MinorSecondUp);
            intervals.Add(GenericScript.Interval.MinorSecondDown);
            intervals.Add(GenericScript.Interval.MajorSecondDown);

            var intervalPick = Random.Range(0, intervals.Count);
            intervalEnum = intervals[intervalPick];
        }
        else
        {
            List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
            intervals.Add(GenericScript.Interval.MinorSecondDown);
            intervals.Add(GenericScript.Interval.MinorSecondUp);
            intervals.Add(GenericScript.Interval.MajorSecondDown);
            intervals.Add(GenericScript.Interval.MajorSecondUp);

            var intervalPick = Random.Range(0, intervals.Count);
            intervalEnum = intervals[intervalPick];
        }






        // Major and Minor 3rds 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode2_Faster"))
        {

            if (noteReference.Note.tag == "C")
            {

                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MajorThirdUp);
                intervals.Add(GenericScript.Interval.MinorThirdUp);

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];


            }
            else if (noteReference.Note.tag == "CSharp")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MajorThirdUp);
                intervals.Add(GenericScript.Interval.MinorThirdUp);
                

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];

            }
            else if (noteReference.Note.tag == "D")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MajorThirdUp);
                intervals.Add(GenericScript.Interval.MinorThirdUp);


                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];

            }
            else if (noteReference.Note.tag == "DSharp")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MajorThirdUp);
                intervals.Add(GenericScript.Interval.MinorThirdUp);
                intervals.Add(GenericScript.Interval.MinorThirdDown);

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];

            }
            else if (noteReference.Note.tag == "GSharp")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MajorThirdDown);
                intervals.Add(GenericScript.Interval.MinorThirdDown);
                intervals.Add(GenericScript.Interval.MinorThirdUp);

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];

            }
            else if (noteReference.Note.tag == "A")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MinorThirdDown);
                intervals.Add(GenericScript.Interval.MajorThirdDown);


                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];

            }
            else if (noteReference.Note.tag == "B")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MajorThirdDown);
                intervals.Add(GenericScript.Interval.MinorThirdDown);

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];
            }
            else if (noteReference.Note.tag == "ASharp")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MajorThirdDown);
                intervals.Add(GenericScript.Interval.MinorThirdDown);
                

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];
            }
            else
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.MinorThirdDown);
                intervals.Add(GenericScript.Interval.MinorThirdUp);
                intervals.Add(GenericScript.Interval.MajorThirdDown);
                intervals.Add(GenericScript.Interval.MajorThirdUp);

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];
            }


        }

        // Perfect Fourth 


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3_Faster"))
        {


            if (noteReference.Note.tag == "C" || noteReference.Note.tag == "CSharp" || noteReference.Note.tag == "D" || noteReference.Note.tag == "DSharp" || noteReference.Note.tag == "E")
            {

                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.PerfectFourthUp);
                

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];


            }    
            else if (noteReference.Note.tag == "B" || noteReference.Note.tag == "ASharp" || noteReference.Note.tag == "A" || noteReference.Note.tag == "GSharp")
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.PerfectFourthDown);

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];
            }
            else
            {
                List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
                intervals.Add(GenericScript.Interval.PerfectFourthDown);
                intervals.Add(GenericScript.Interval.PerfectFourthUp);

                var intervalPick = Random.Range(0, intervals.Count);
                intervalEnum = intervals[intervalPick];
            }
        }

        IntervalText.text = GenericScript.IntervalChange(intervalEnum); // update the interval text on the screen 
    }


    #endregion
}
