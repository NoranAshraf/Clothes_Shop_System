using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Category", menuName = "New Category")]

public class Categoty : ScriptableObject
{
    public List<OutfitPart> Items = new List<OutfitPart>();
    [NonSerialized]public int previewSelectIndex;
    [NonSerialized]public int selectIndex;


    public OutfitPart GetPreviewItem()
    {
        return Items[previewSelectIndex];
    }

    public OutfitPart GetSelectItem()
    {
        return Items[selectIndex];
    }

    public void SetPreviewItem(int index)
    {
        previewSelectIndex = index;
    }
    public void SetSelectIndex(int index)
    {
        selectIndex = index;
    }
}
