using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewOutfit",menuName ="Outfit")]
public class OutfitPart : ScriptableObject
{
    public bool isOwned;
    public int price;
    public Sprite OutfitSprite;

   
}
