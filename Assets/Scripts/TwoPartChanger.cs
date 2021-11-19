using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPartChanger : MonoBehaviour
{
    public SpriteRenderer bodyPartR;
    public SpriteRenderer bodyPartL;

    public List<OutfitPart> Roptions = new List<OutfitPart>();
    public List<OutfitPart> Loptions = new List<OutfitPart>();
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject AddButton;

    private int CurrentIndex = 0;

    // Start is called before the first frame update
    public void NextOption()
    {

        CurrentIndex++;

        if (CurrentIndex >= Roptions.Count)
        {
            CurrentIndex = 0;
        }
        bodyPartR.sprite = Roptions[CurrentIndex].OutfitSprite;
        bodyPartL.sprite = Loptions[CurrentIndex].OutfitSprite;
        checkIfOwned();
   
    }
    public void PreviousOption()
    {
        CurrentIndex--;


        if (CurrentIndex <= 0)
        {

            CurrentIndex = Roptions.Count - 1;
 

        }
        bodyPartR.sprite = Roptions[CurrentIndex].OutfitSprite;
        bodyPartL.sprite = Loptions[CurrentIndex].OutfitSprite;
        checkIfOwned();
    }
    void checkIfOwned()
    {
        if (Roptions[CurrentIndex].isOwned&&Loptions[CurrentIndex].isOwned)
        {
            AddButton.SetActive(false);
        }
        else
        {
            AddButton.SetActive(true);

        }
    }
    
}


