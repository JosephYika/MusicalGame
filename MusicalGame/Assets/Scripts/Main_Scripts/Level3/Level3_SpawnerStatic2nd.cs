/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3_SpawnerStatic2nd : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;
    private GameObject note;
    public GameObject Note { get { return note; } }

    private float minimumX_Negative;
    private float maximumX_Positive;
    private float _xIncrement;
    public static int generateStaticKeys;
    public float notePos;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        GenerateFirstKey2();
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the key to always 'alive'
        if (note == null)
        {
            note = GenerateNewKey2();
        }
        // check the position of x while below - 2.9 
        if (note.transform.position.y < -2.5)
        {
            notePos = note.transform.position.x;
        }
    }

    public GameObject GenerateFirstKey2()
    {
        //   var index = Random.Range(0, Keys.Length);
        var index = generateStaticKeys++ % Keys.Length;

        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name);
        var vector2D = new Vector2(posX, transform.position.y);
        transform.position = vector2D;

        // Instantiate key on corresponding position
        return note = Instantiate(Keys[index], vector2D, Quaternion.identity);
    }

    public GameObject GenerateNewKey2()
    {
        DestroyKey2();
        // Generate index for 'note' to instantiate
        // var index = Random.Range(0, Keys.Length);
        var index = generateStaticKeys++ % Keys.Length;

        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name);
        var vector2D = new Vector2(posX, transform.position.y);
        transform.position = vector2D;

        // Instantiate key on corresponding position
        return note = Instantiate(Keys[index], vector2D, Quaternion.identity);
    }

    public void DestroyKey2()
    {
        // Check if key is already destroyed 
        // If so: do nothing, if not: destroy it
        if (note == null)
        {
            return;
        }
        notePos = note.transform.position.x;
        Destroy(note);

    }

    #endregion
}
