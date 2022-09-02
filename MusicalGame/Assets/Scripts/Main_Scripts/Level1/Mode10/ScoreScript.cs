/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI scoreOnTheScreen;
    //public AudioSource failSound;
    //public AudioSource successSound;
    
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoardStatic.ResetPoints();
      //  scoreOnTheScreen.text = ScoreBoardStatic.ScoreAPoint.ToString();
    }
    private void Update()
    {
        ScoreBoardStatic.ChangeScene();
    }

    public void OnTriggerEnter2D(Collider2D note) // if my key collides with the note ( the note that is coming down from the top) do the code inside
    {
        if (note.tag == "C") // if this key collides with C note add one poissnt 
        {
         //   successSound.Play();
            ScoreBoardStatic.IncrementPoints();
            
        }
        else // if it collides with any other note take away one point 
        {
         //   failSound.Play();
            ScoreBoardStatic.DecrementPoints();
            
        }
        scoreOnTheScreen.text = ScoreBoardStatic.ScoreAPoint.ToString();
       
    }
    #endregion

    //public void ColissionDetected(ScoreScriptC_Sharp scoreScriptC_Sharp)
    //{
       
    //}
}
