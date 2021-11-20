using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnClickChanger : MonoBehaviour
{
    [SerializeField] Categoty category;
    [SerializeField] int selectIndex;
    [SerializeField] SpriteRenderer []bodyParts;
    [SerializeField] Text PriceText;
    [SerializeField] Image img;
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject BuyButton;

    // Start is called before the first frame update
    void Start()
    {
        selectIndex = transform.GetSiblingIndex();
       
        if (category.Items[selectIndex].price == 0||category.Items[selectIndex].isOwned)
              PriceText.gameObject.SetActive(false);

        PriceText.text = category.Items[selectIndex].price.ToString() + "$";
        img.sprite = category.Items[selectIndex].OutfitImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void change()
    {
        
        category.SetPreviewItem(selectIndex);
        if (category.GetPreviewItem().isOwned)
        {
            category.SetSelectIndex(selectIndex);
        }
        gameManager.itemPrice = category.GetPreviewItem().price;

        for (int i = 0; i < bodyParts.Length; i++)
        {
            bodyParts[i].sprite = category.GetPreviewItem().OutfitSprite[i];
        }
 
        if (category.GetPreviewItem().price > 0&&!category.GetPreviewItem().isOwned)
        {
            BuyButton.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(false);

        }
    }
    public void Buy()
    {
        if (gameManager.totalMoney >= gameManager.itemPrice)
        {
            BuyButton.SetActive(false);
            PriceText.gameObject.SetActive(false);
            gameManager.totalMoney -= gameManager.itemPrice;
            category.GetPreviewItem().isOwned = true;
            category.SetSelectIndex(selectIndex);
        }
    }
  
}
