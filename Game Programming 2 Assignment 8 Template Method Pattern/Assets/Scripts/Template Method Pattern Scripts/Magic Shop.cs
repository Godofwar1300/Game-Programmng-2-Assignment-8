using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicShop : Shops
{

    private string shopDescription;
    private string shopType;

    public override string GetShopType()
    {
        Debug.Log("This is a magic shop");
        shopType = "Magic";
        return shopType;
    }

    public override string ShopDescription()
    {
        shopDescription = "Welcome to _____! The end to all your arcane needs.";
        return shopDescription;
    }

    public override bool wantsToHearDescription()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
