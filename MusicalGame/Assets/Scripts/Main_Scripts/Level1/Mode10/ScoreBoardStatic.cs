/*
 Copyright (c) Józef Yika
*/
using UnityEngine.SceneManagement;

/// <summary>
/// Static Class for updating the score on the screen and changing the scenes depending on the aquired score 
/// </summary>
public static class ScoreBoardStatic
{
    #region Variables
    private static int scoreAPoint; // one point 
    
    /// <summary>
    ///  returns the score 
    /// </summary>
    public static int ScoreAPoint 
    {
        get { return scoreAPoint; }

    }

    #endregion
   
    #region Unity Methods

    /// <summary>
    /// Increments by one point 
    /// </summary>
    public static void  IncrementPoints ()
    {
        scoreAPoint++; 
    }

    /// <summary>
    /// Decrements by one point 
    /// </summary>
    public static void DecrementPoints() => scoreAPoint--;

    /// <summary>
    /// resets to zero 
    /// </summary>
    public static void ResetPoints() => scoreAPoint = 0;


    /// <summary>
    /// Change scene depending on the active game scene and aquired score 
    /// For demonstration purposes this should be set to 3 
    /// For game release to the actual score e.g. 15 
    /// The number on the right of the if statement indicates the number of points assigned to a given scene 
    /// </summary>
    public static void ChangeScene()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_IntermediaryModeWhite") && scoreAPoint == 3) //15
        {
           
                SceneManager.LoadScene("Level1_Mode1");
            
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode1") && scoreAPoint == 3) //15
        {

            SceneManager.LoadScene("Level1_Mode2");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode2") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode3");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode3") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode4");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode4") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode8_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode8_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode8_Faster");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode8_Faster") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode8_Fast");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode8_Fast") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_IntermediaryModeBlack");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_IntermediaryModeBlack") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode5");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode5") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode6");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode6") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode7");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode7") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode9_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode9_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode9_Faster");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode9_Faster") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode9_Fast");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode9_Fast") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_White_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_White_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_White_Faster");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_White_Faster") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_Black_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_Black_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_Black_Fast");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_Black_Fast") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10");

        }

      

    }




    #endregion
}
