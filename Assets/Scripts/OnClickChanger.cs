using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnClickChanger : MonoBehaviour
{
    [SerializeField] OutfitPart outfit;
    [SerializeField] SpriteRenderer player;
    [SerializeField] Text PriceText;
    [SerializeField] Image img;
    [SerializeField] GameManager gameManager;
    [SerializeField] Button btn;

    // Start is called before the first frame update
    void Start()
    {
        PriceText.text = outfit.price.ToString() + "$";
        img.sprite = outfit.OutfitSprite;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void change()
    {
     
        gameManager.itemPrice = outfit.price;
        player.sprite = outfit.OutfitSprite;
        gameManager.totalPrice += outfit.price;
 
        if (outfit.price > 0)
        {
            btn.interactable = true;
        }
        else
        {
            btn.interactable = false;
        }
    }

}
