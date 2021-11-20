using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameManager : MonoBehaviour
{
        
    [SerializeField] Camera cam;
    [SerializeField] Text MoneyText;
    [SerializeField] GameObject ShopWindow;
    public int totalPrice;
    public int itemPrice;
    public int totalMoney;

    [SerializeField] Categoty[] categories;

    [SerializeField] BodyPart[] bodyParts;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        MoneyText.text = totalMoney.ToString() + "$";


    }

  public  void MoneyCalculator()
    {
       if (totalMoney >=itemPrice)
            {
               totalMoney -=itemPrice;

            }
     }

    public void CloseShop()
    {
        ShopWindow.SetActive(false);
        for(int i=0; i <= bodyParts.Length-1; i++)
        {
            Categoty category = categories[i];
            for(int j = 0; j <= bodyParts[i].BodyParts.Length-1; j++)
            {
                bodyParts[i].BodyParts[j].sprite = category.GetSelectItem().OutfitSprite[j];
            }
        }
    }
  
   
}
