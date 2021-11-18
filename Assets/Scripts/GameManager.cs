using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameManager : MonoBehaviour
{
        
    [SerializeField] Camera cam;
    [SerializeField] Text MoneyText;
    [SerializeField] int MoneyValue;
    public int totalPrice;
    public List<OutfitPart> Items = new List<OutfitPart>();
    public bool btnClicked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = MoneyValue.ToString();
    }
   public void ShopNow()
    {
        cam.transform.position = new Vector3(55, 0, -10);
    }

    
   
}
