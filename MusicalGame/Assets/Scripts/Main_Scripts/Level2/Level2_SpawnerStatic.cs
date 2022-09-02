/*
 Copyright (c) Józef Yika
*/


using UnityEngine;

public class Level2_SpawnerStatic : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys; // notes array 
    private GameObject note; // actual note from the spawner 
    public GameObject Note { get { return note; } } // returns an actual note so that I can use it in any other script I want -- I can access it this way 

    //private float minimumX_Negative;
    //private float maximumX_Positive;
    //private float _xIncrement;
    public static int generateStaticKeys; // gerenating static notes from the spawner 
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        GenerateFirstKey(); // generate first note -- see below Generate FIrst Key function 
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the note to be always 'alive' i.e. if there isn't any note Generate it -- see Generate New Key function 
        if (note == null)
        {
            note = GenerateNewKey();
        }
    }

    /// <summary>
    /// Generates first note from the spanwer 
    /// </summary>
    /// <returns></returns>
    public GameObject GenerateFirstKey()
    {
        
        var index = generateStaticKeys++ % Keys.Length; // generates notes in order 
        
        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name); // assign a new note position 
        var vector2D = new Vector2(posX, transform.position.y); // calculate the new note position 
        transform.position = vector2D; // change the actual position of the note accordingly 

        // Instantiate note on corresponding position
        return note = Instantiate(Keys[index], vector2D, Quaternion.identity);
    }

    /// <summary>
    /// Generates New Note
    /// </summary>
    /// <returns></returns>
    public GameObject GenerateNewKey()
    {
        DestroyKey();
        // Generate index for 'key' to instantiate

        //  var index = generateStaticKeys++ % Keys.Length;
        var index = Random.Range(0, Keys.Length); // randomly selects notes 
        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name); // assign a new note position 
        var vector2D = new Vector2(posX, transform.position.y); // calculate the new note position
        transform.position = vector2D; // change the actual position of the note accordingly

        // Instantiate key on corresponding position
        return note = Instantiate(Keys[index], vector2D, Quaternion.identity);
    }

    public void DestroyKey()
    {
        // Check if note is already destroyed 
        // If destroyed: do nothing, if not: destroy it
        if (note == null)
        {
            return;
        }
        Destroy(note);
       
    }

    #endregion
}