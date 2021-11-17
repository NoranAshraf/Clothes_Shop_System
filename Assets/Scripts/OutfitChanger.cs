using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    public SpriteRenderer bodyPart;

    public List<Sprite> options = new List<Sprite>();

    protected int CurrentIndex = 0;
    // Start is called before the first frame update
    protected virtual void NextOption()
    {
        CurrentIndex++;
        if (CurrentIndex >= options.Count)
        {
            CurrentIndex = 0;
        }
        bodyPart.sprite = options[CurrentIndex];
    }
    protected virtual void PreviousOption()
    {
        CurrentIndex--;
        if (CurrentIndex <= 0)
        {
            CurrentIndex = options.Count - 1;
        }
        bodyPart.sprite = options[CurrentIndex];
    }

   
}
