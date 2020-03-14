/*
 * (Christopher Green)
 * (GeneralGoodsShop.cs)
 * (Assignment 8)
 * (This script is a class that inhertis from the sbstract superclass and defines it's own functionality for execution)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralGoodsShop : Shops
{
    public override void ChangeChoices()
    {
        testDrive.shopButtonChoices.SetActive(false);
        testDrive.generalGoodsPurshaseChoiceButton.SetActive(true);
        testDrive.choiceOne.transform.GetChild(0).GetComponent<Text>().text = "Apples";
        testDrive.choiceTwo.transform.GetChild(0).GetComponent<Text>().text = "Bundle of Wood";
        testDrive.choiceThree.transform.GetChild(0).GetComponent<Text>().text = "Clothes";
    }

    public override string GetShopType()
    {
        shopType = "General Store";
        return shopType;
    }

    public override string Greeting()
    {
        greeting = "Welcome to my shop traveller! How may I help you today? \n Do you wish to hear about my little shop (Y/N)?";
        return greeting;
    }

    public override string ShopDescription()
    {
        shopDescription = "I have an assortment of goods that you can choose from. Unfortunately I only have a limted stock right now due to the plague surging through the land but feel free to buy whatever I have left.";
        return shopDescription;
    }

    public override string ShopKeeperToUserResponse(bool usersResponse)
    {
        if (usersResponse)
        {
            shopkeeperResponse = "Great, it'll be my pleasure! \n\n" + ShopDescription();
        }
        else if (!usersResponse)
        {
            shopkeeperResponse = "Oh ok, well I hope you find what you're looking for.";
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
