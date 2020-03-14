/*
 * (Christopher Green)
 * (MagicShop.cs)
 * (Assignment 8)
 * (This script is a class that inhertis from the sbstract superclass and defines it's own functionality for execution)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicShop : Shops
{
    public override void ChangeChoices()
    {
        testDrive.shopButtonChoices.SetActive(false);
        testDrive.magicPurshaseChoicesButton.SetActive(true);
        testDrive.choiceOne.transform.GetChild(0).GetComponent<Text>().text = "Inferno Scroll";
        testDrive.choiceTwo.transform.GetChild(0).GetComponent<Text>().text = "Freezing Winds";
        testDrive.choiceThree.transform.GetChild(0).GetComponent<Text>().text = "Crystal Ball";
    }

    public override string GetShopType()
    {
        shopType = "Magic Shop";
        return shopType;
    }

    public override string Greeting()
    {
        greeting = "Welcome to my shop traveller! How may I help you today? \n Do you wish to hear about my shop (Y/N)?";
        return greeting;
    }

    public override string ShopDescription()
    {
        shopDescription = "Hello, my name is Ezra and welcome to Scrolls and Trolls! The end to all your arcane needs.";
        return shopDescription;
    }

    public override string ShopKeeperToUserResponse(bool usersResponse)
    {
        if (usersResponse)
        {
            shopkeeperResponse = "Well great! Oh boy I can't wait for you to learn all about my little shop! \n\n" + ShopDescription();
        }
        else if (!usersResponse)
        {
            shopkeeperResponse = "Aww, that's too bad... Well, just take a look around and I'll be here if you need any help.";
        }

        return shopkeeperResponse;
    }

    public override int PurchaseItem(int cost)
    { 
        return testDrive.totalMoney -=cost;
    }

    public override bool wantsToHearDescription(bool userResponse)
    {
        if(userResponse)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
