/*
 * (Christopher Green)
 * (WeaponsShop.cs)
 * (Assignment 8)
 * (This script is a class that inhertis from the sbstract superclass and defines it's own functionality for execution)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponsShop : Shops
{
    public override void ChangeChoices()
    {
        testDrive.shopButtonChoices.SetActive(false);
        testDrive.WeaponPurchaseChoicesButton.SetActive(true);
        testDrive.choiceOne.transform.GetChild(0).GetComponent<Text>().text = "Sword";
        testDrive.choiceTwo.transform.GetChild(0).GetComponent<Text>().text = "Battle Axe";
        testDrive.choiceThree.transform.GetChild(0).GetComponent<Text>().text = "Bow and Arrows";
    }

    public override string GetShopType()
    {
        shopType = "Weapons Shop";
        return shopType;
    }

    public override string Greeting()
    {
        greeting = "Huh, you didn't run? Ok, would you like to know more about what I got to sell (Y/N)";
        return greeting;
    }

    public override string ShopDescription()
    {
        shopDescription = "My name is Morzag, Buy something or get out, before I crush your puny skull";
        return shopDescription;
    }

    public override string ShopKeeperToUserResponse(bool usersResponse)
    {
        if (usersResponse)
        {
            shopkeeperResponse = "Fine...I guess since you asked \n\n" + ShopDescription();
        }
        else if (!usersResponse)
        {
            shopkeeperResponse = "Good. I didn't want to tell you anyway.";
        }

        return shopkeeperResponse;
    }

    public override int PurchaseItem(int cost)
    {
        return testDrive.totalMoney -= cost;
    }

    public override bool wantsToHearDescription(bool userResponse)
    {
        if (userResponse)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
