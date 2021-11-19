using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnclickTwochanger : MonoBehaviour
{
    [SerializeField] OutfitTwoParts outfit2parts;
    [SerializeField] SpriteRenderer rightPart;
    [SerializeField] SpriteRenderer leftpart;
    [SerializeField] Text PriceText;
    [SerializeField] Image img;
    [SerializeField] GameManager gameManager;
    [SerializeField] Button btn;

    // Start is called before the first frame update
    void Start()
    {

       PriceText.text = outfit2parts.price.ToString() + "$";

        img.sprite = outfit2parts.outfitImage;

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void change2()
    {
        gameManager.itemPrice = outfit2parts.price;

        rightPart.sprite = outfit2parts.OutfitRightSprite;
        leftpart.sprite = outfit2parts.OutfitleftSprite;
        if (outfit2parts.price > 0)
        {
            btn.interactable = true;
        }
        else
        {
            btn.interactable = false;
        }
    }

   
}
