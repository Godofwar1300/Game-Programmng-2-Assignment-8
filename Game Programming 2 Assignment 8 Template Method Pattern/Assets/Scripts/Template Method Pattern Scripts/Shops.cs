using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shops
{

    public Text bodyText;
    public Text shopTitleText;

    private string greeting;

    public ShopTestDrive testDrive;

    public void Interact()
    {
        testDrive = GameObject.Find("ShopkeeperTestDrive").GetComponent<ShopTestDrive>();

        ChangeChoices();

        testDrive.actualTitleText.text = GetShopType() + " Shop";

        testDrive.actualBodyText.text = Greeting();

        if(wantsToHearDescription(testDrive.userResponse) == true && testDrive.inWeaponsShop)
        {
            testDrive.actualBodyText.text = "Fine...I guess since you asked \n\n" + ShopDescription();
        }
        else if(wantsToHearDescription(testDrive.userResponse) == true && testDrive.inMagicShop)
        {
            testDrive.actualBodyText.text = "Well great! Oh boy I can't wait for you to learn all about my little shop! \n\n" + ShopDescription();
        }
        else if(wantsToHearDescription(testDrive.userResponse) == false && testDrive.inWeaponsShop)
        {
            testDrive.actualBodyText.text = "Good. I didn't want to tell you anyway.";
        }
        else if (wantsToHearDescription(testDrive.userResponse) == false && testDrive.inMagicShop)
        {
            testDrive.actualBodyText.text = "Aww, that's too bad... Well, just take a look around and I'll be here if you need any help.";
        }

        // Maybe other things later

    }
    public abstract string GetShopType();

    public abstract string ShopDescription();

    public abstract void ChangeChoices();

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

    public virtual bool wantsToHearDescription(bool userResponse)
    {
        userResponse = true;
        return userResponse;
    }
}
