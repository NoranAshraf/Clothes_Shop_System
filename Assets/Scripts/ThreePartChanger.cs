using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePartChanger : OutfitChanger 
{


    public SpriteRenderer RightArm;
    public SpriteRenderer LeftArm;

    public List<Sprite> Roptions = new List<Sprite>();
    public List<Sprite> Loptions = new List<Sprite>();



    // Start is called before the first frame update
    protected override void NextOption()
    {
        base.NextOption();
        CurrentIndex++;
     
        if (CurrentIndex >= Roptions.Count )
        {
            CurrentIndex = 0;
        }
        RightArm.sprite = Roptions[CurrentIndex];
        LeftArm.sprite = Loptions[CurrentIndex];

    }
    protected override void PreviousOption()
    {
        base.PreviousOption();
        CurrentIndex--;
        if (CurrentIndex <= 0 )
        {

            CurrentIndex = Roptions.Count - 1;

        }
        RightArm.sprite = Roptions[CurrentIndex];
        LeftArm.sprite = Loptions[CurrentIndex];
    }
}
