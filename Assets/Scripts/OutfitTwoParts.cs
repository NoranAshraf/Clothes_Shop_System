using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewOutfit", menuName = "2Outfit")]

public class OutfitTwoParts : ScriptableObject
{
    public bool isOwned;
    public int price;
    public Sprite OutfitRightSprite;
    public Sprite OutfitleftSprite;
    public Sprite outfitImage;
}
