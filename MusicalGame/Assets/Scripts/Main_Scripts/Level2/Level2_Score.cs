/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level2_Score : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI scoreText; // text in Unity 
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoardStatic.ResetPoints(); // Reset points 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion
}
