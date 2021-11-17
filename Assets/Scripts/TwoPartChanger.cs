using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPartChanger : MonoBehaviour
{
    public SpriteRenderer bodyPartR;
    public SpriteRenderer bodyPartL;

    public List<Sprite> Roptions = new List<Sprite>();
    public List<Sprite> Loptions = new List<Sprite>();


    private int CurrentIndex = 0;

    // Start is called before the first frame update
    public void NextOption()
    {

        CurrentIndex++;

        if (CurrentIndex >= Roptions.Count)
        {
            CurrentIndex = 0;
        }
        bodyPartR.sprite = Roptions[CurrentIndex];
        bodyPartL.sprite = Loptions[CurrentIndex];

    }
    public void PreviousOption()
    {
        CurrentIndex--;


        if (CurrentIndex <= 0)
        {

            CurrentIndex = Roptions.Count - 1;
 

        }
        bodyPartR.sprite = Roptions[CurrentIndex];
        bodyPartL.sprite = Loptions[CurrentIndex];
    }
}


