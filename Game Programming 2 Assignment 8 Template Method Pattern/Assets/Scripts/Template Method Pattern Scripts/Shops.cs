using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shops
{

    public Text bodyText;
    public Text shopTitleText;

    private string greeting;

    ShopTestDrive testDrive;

    public void Interact()
    {
        testDrive = GameObject.Find("ShopkeeperTestDrive").GetComponent<ShopTestDrive>();

        testDrive.actualTitleText.text = GetShopType() + " Shop";

        testDrive.actualBodyText.text = Greeting();

        if(wantsToHearDescription())
        {
            testDrive.actualBodyText.text = "Allow me to tell you!" + ShopDescription();
        }
        else
        {
            testDrive.actualBodyText.text = "Ok, you're loss friend";
        }

        // Maybe other things later

    }

    public abstract string GetShopType();

    public abstract string ShopDescription();

    public string Greeting()
    {
        if(GetShopType() == "Magic")
        {
            greeting = "Welcome to my shop traveller! How may I help you today? \n Do you wish to hear about my shop (Y/N)?";
        }
        else if(GetShopType() == "Weapons")
        {
            greeting = "Huh, you didn't run? Ok, would you like to know more about what I got to sell (Y/N)?";
        }

        return greeting;

    }

    public virtual bool wantsToHearDescription()
    {
        return true;
    }
}
