///*
// Copyright (c) Józef Yika
//*/


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;

//public class ChangeIntervalText : MonoBehaviour
//{
//    #region Variables
//    public TextMeshProUGUI Interval;
//    public List<string> intervalListUp;
//    public List<string> intervalListDown;
//    public List<string> allIntervals;
//    public static int generateIntervalsInOrder;
//    public Level2_SpawnerStatic noteReference;

    
//    #endregion

//    #region Unity Methods

//    // Start is called before the first frame update
//    void Start()
//    {

//        intervalListUp = new List<string>();
//        intervalListUp.Add("Minor 2nd <br><sprite=4><br>");
//        intervalListUp.Add("Major 2nd <br><sprite=4><br>");

//        intervalListDown = new List<string>();
//        intervalListDown.Add("Minor 2nd <br><sprite=2><br>");
//        intervalListDown.Add("Major 2nd <br><sprite=2><br>");

//        allIntervals = new List<string>();
//        allIntervals.Add("Minor 2nd <br><sprite=4><br>");
//        allIntervals.Add("Major 2nd <br><sprite=4><br>");
//        allIntervals.Add("Minor 2nd <br><sprite=2><br>");
//        allIntervals.Add("Major 2nd <br><sprite=2><br>");

//        noteReference = FindObjectOfType<Level2_SpawnerStatic>();

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    public void GenerateNewIntervalOnTheScreen()
//    {
//       // Adding boundaries - if the spawned notes are C and C# generate only Minor 2nd or Major Second Interval UP , not down. There is not enough space to build it down..
//       // Accordingly If its B or A Sharp then an Interval will only indacte to build it down. 
       
//        if(noteReference.Note.tag == "C" || noteReference.Note.tag == "CSharp")
//        {
//            // Interval.text = intervalListUp[generateIntervalsInOrder++ % intervalListUp.Count];
//            Interval.text = intervalListUp[Random.Range(0,intervalListUp.Count)];
//        }

//        else if (noteReference.Note.tag == "B" || noteReference.Note.tag == "ASharp")
//        {
//            Interval.text = intervalListDown[Random.Range(0, intervalListDown.Count)];
//        }
//        else
//        {
//            Interval.text = allIntervals[Random.Range(0, allIntervals.Count)];
//        }
        

//    }


//    #endregion

//}
