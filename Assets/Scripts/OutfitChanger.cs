using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    public SpriteRenderer bodyPart;

    public List<OutfitPart> options = new List<OutfitPart>();

    private int CurrentIndex = 0;
    [SerializeField] GameManager gameManager;
    public GameObject AddButton;

   
    public  void NextOption()
    {
        CurrentIndex++;
        if (CurrentIndex >= options.Count)
        {
            CurrentIndex = 0;
        }
        bodyPart.sprite = options[CurrentIndex].OutfitSprite[0];
        checkIfOwned();
    }
    public  void PreviousOption()
    {
        CurrentIndex--;
        if (CurrentIndex <= 0)
        {
            CurrentIndex = options.Count - 1;
        }
        bodyPart.sprite = options[CurrentIndex].OutfitSprite[0];
        checkIfOwned();
    }

    void checkIfOwned()
    {
        if (options[CurrentIndex].isOwned)
        {
            AddButton.SetActive(false);
        }
        else
        {
            AddButton.SetActive(true);
          
        }
    }
   
}
