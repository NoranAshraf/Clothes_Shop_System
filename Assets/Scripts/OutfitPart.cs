using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName ="NewOutfit",menuName ="Outfit")]
public class OutfitPart : ScriptableObject
{
    [NonSerialized] public bool isOwned;
    public int price;
    public Sprite []OutfitSprite;
    public Sprite OutfitImage;
    
}
