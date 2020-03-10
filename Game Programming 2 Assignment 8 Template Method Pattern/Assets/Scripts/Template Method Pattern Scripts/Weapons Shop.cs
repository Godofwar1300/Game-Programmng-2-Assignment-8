using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsShop : Shops
{

    private string shopDescription;
    private string shopType;

    public override string GetShopType()
    {
        Debug.Log("This is a weapons shop");
        shopType = "Weapons";
        return shopType;
    }

    public override string ShopDescription()
    {
        shopDescription = "(Grunts and narrows eyes) Buy something or get out, before I crush your puny skull";
        return shopDescription;
    }

    public override bool wantsToHearDescription()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
