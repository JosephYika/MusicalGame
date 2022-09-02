/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialSystem : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI text;
    public List<string> popUpMessages;
    
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        
        popUpMessages = new List<string>();


        text.text = "Keep pressing The Right Arrow to follow the tutorial";

        popUpMessages.Add("This is a piano");
        popUpMessages.Add("On a standard piano there are 88 keys");
        popUpMessages.Add("However, only 12 of them are DIFFERENT AND UNIQUE");
        popUpMessages.Add("These 12 Keys are repeated throughout the entire piano");

       
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < popUpMessages.Count -1; i++)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) )
            {

                text.text = popUpMessages[i];
            }
           

        }
        
    }

    #endregion
}
