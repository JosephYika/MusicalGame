using UnityEngine;

/// <summary>
/// Class GenericScript contains general scripts used in many levels
/// </summary>
public static class GenericScript
{
    /// <summary>
    /// This Function returns note position based on GameObject name
    /// i.e. for 'C' key returns position -9, 
    /// for 'A#' returns 11 etc.
    /// </summary>
    /// <param name="gObject"></param>
    /// <returns></returns>
    public static float CalculatePositionFromNoteName(string noteName)
    {
        return noteName switch
        {
            "C" => -9,
            "C#" => -7,
            "Db" => -7,
            "D" => -5,
            "D#" => -3,
            "Eb" => -3,
            "E" => -1,
            "F" => 1,
            "F#" => 3,
            "Gb" => 3,
            "G" => 5,
            "G#" => 7,
            "Ab" => 7,
            "A" => 9,
            "A#" => 11,
            "Bb" => 11,
            "B" => 13,
            _ => -9
        };
    }

    /// <summary>
    /// Analogiclly to the function above this function return the name of the note based on the position of then 
    /// e.g. -9 on the x axis is the position of C , meaning it will return string "C"
    /// </summary>
    /// <param name="position"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static string CalculateNoteNameFromPosition(float position, string type = "Sharp")
    {
        switch (type)
        {
            case "Sharp":
                return position switch
                {
                    -9 => "C",
                    -7 => "C#",
                    -5 => "D",
                    -3 => "D#",
                    -1 => "E",
                    1 => "F",
                    3 => "F#",
                    5 => "G",
                    7 => "G#",
                    9 => "A",
                    11 => "A#",
                    13 => "B",
                    _ => "C"
                };

            case "Flat":
                return position switch
                {
                    -9 => "C",
                    -7 => "Db",
                    -5 => "D",
                    -3 => "Eb",
                    -1 => "E",
                    1 => "F",
                    3 => "Gb",
                    5 => "G",
                    7 => "Ab",
                    9 => "A",
                    11 => "Bb",
                    13 => "B",
                    _ => "C"
                };
            default:
                return position switch
                {
                    -9 => "C",
                    -7 => "C#",
                    -5 => "D",
                    -3 => "D#",
                    -1 => "E",
                    1 => "F",
                    3 => "F#",
                    5 => "G",
                    7 => "G#",
                    9 => "A",
                    11 => "A#",
                    13 => "B",
                    _ => "C"
                };
        }
    }



    /// <summary>
    /// Function compares given key with existing tags , 
    /// This is used instead of a huge if statement that would have to be written every time while the note are colliding 
    /// This functions is called every time the notes collide with the keyboard to check which note collided 
    /// This must be checked for a few things, most importantly to update the score
    /// </summary>
    /// <param name="pianoKey"></param>
    /// <returns></returns>
    public static bool CompareTagsExtension(this Collider2D pianoKey)
    {
        return pianoKey.CompareTag("C") || pianoKey.CompareTag("CSharp")
            || pianoKey.CompareTag("D") || pianoKey.CompareTag("DSharp")
            || pianoKey.CompareTag("E") || pianoKey.CompareTag("F")
            || pianoKey.CompareTag("FSharp") || pianoKey.CompareTag("G")
            || pianoKey.CompareTag("GSharp") || pianoKey.CompareTag("A")
            || pianoKey.CompareTag("ASharp") || pianoKey.CompareTag("B");
    }

    /// <summary>
    /// This enumarator is an enumarator of intervals 
    /// The data from here is passed to --> IntervalChange(Interval interval) function below, to determine the interval text based on its type 
    /// </summary>
    public enum Interval
    {
        MinorSecondDown,
        MinorSecondUp,
        MajorSecondDown,
        MajorSecondUp,
        MinorThirdDown,
        MinorThirdUp,
        MajorThirdDown,
        MajorThirdUp,
        PerfectFourthDown,
        PerfectFourthUp,
        AugumentedFourthDown,
        AugumentedFourthUp,
        PerfectFifthDown,
        PerfectFifthUp,
        DiminishedFifthDown, 
        DiminishedFifthUp,
    }
    /// <summary>
    /// This enumarator is an enumarator of chords
    /// The data from here is passed to --> ChordChange(Chord chord) function below, to determine the chord text based on its type
    /// </summary>
    public enum Chord
    { 
        C_MajorUp,
        D_MajorUp,
        E_MajorUp, 
        CSharp_MajorUp,
        DShapr_MajorUp,
        C_MinorUp,
        D_MinorUp,
        E_MinorUp,
        DSharp_MinorUp

    
    }


    //intervalListUp.Add("Minor 2nd <br><sprite=4><br>");
    //    intervalListUp.Add("Major 2nd <br><sprite=4><br>");

    //    intervalListDown = new List<string>();
    //    intervalListDown.Add("Minor 2nd <br><sprite=2><br>");
    //    intervalListDown.Add("Major 2nd <br><sprite=2><br>");

    //    allIntervals = new List<string>();
    //    allIntervals.Add("Minor 2nd <br><sprite=4><br>");
    //    allIntervals.Add("Major 2nd <br><sprite=4><br>");
    //    allIntervals.Add("Minor 2nd <br><sprite=2><br>");
    //    allIntervals.Add("Major 2nd <br><sprite=2><br>");



    // return the string based on the specific element from an enum that is passed as an argument in that function
    // argument ( interval ) of type enum ---> IntervalChange(interval) ---> checks the assigned string to this enum and returns it 

    public static string IntervalChange(Interval interval)
    {
        return interval switch 
        {
            
            Interval.MinorSecondDown => "Minor 2nd <br><sprite=2><br>",
            Interval.MinorSecondUp => "Minor 2nd <br><sprite=4><br>",
            Interval.MajorSecondDown => "Major 2nd <br><sprite=2><br>",
            Interval.MajorSecondUp => "Major 2nd <br><sprite=4><br>",
            Interval.MinorThirdDown => "Minor 3rd <br><sprite=2><br>",
            Interval.MinorThirdUp => "Minor 3rd <br><sprite=4><br>",
            Interval.MajorThirdDown => "Major 3rd <br><sprite=2><br>",
            Interval.MajorThirdUp => "Major 3rd <br><sprite=4><br>",
            Interval.PerfectFourthDown => "Perfect 4th <br><sprite=2><br>",
            Interval.PerfectFourthUp => "Perfect 4th <br><sprite=4><br>",
            _ => "Oops, Wrong Interval"




        };

    }

    // return the string based on the specific element from an enum that is passed as an argument in that function
    // argument ( chord ) of type enum ---> ChordChange ---> checks the assigned string to this enum and returns it 
    public static string ChordChange(Chord chord)
    {
        return chord switch
        {

            Chord.C_MajorUp => "C Major <br><sprite=4><br>",
            Chord.D_MajorUp => "D Major <br><sprite=4><br>",
            Chord.E_MajorUp => "E Major <br><sprite=4><br>",
            Chord.CSharp_MajorUp => "C# Major<br><sprite=4><br>",
            Chord.DShapr_MajorUp => "D# Major<br><sprite=4><br>",

            Chord.C_MinorUp => "C Minor <br><sprite=4><br>",
            Chord.D_MinorUp => "D Minor <br><sprite=4><br>",
            Chord.E_MinorUp => "E Minor <br><sprite=4><br>",    
            Chord.DSharp_MinorUp => "D# Minor<br><sprite=4><br>",
            _ => "Oops, Wrong Chord"




        };

    }

}