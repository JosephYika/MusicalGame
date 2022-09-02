/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level2_DistanceToStaticNote : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Level2_SpawnerStatic staticNotesCheckPoint;

    //[SerializeField]
    //private TextMeshProUGUI distance;

    private float distanceBtwTwoNotes;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceBtwTwoNotes = (staticNotesCheckPoint.Note.transform.position.x - transform.position.x);
        //distance.text = "Distance : " + distanceBtwTwoNotes.ToString("F1") + "units";
        Debug.Log("Distance : " + distanceBtwTwoNotes.ToString("F1") + "units");
    }

    #endregion
}
