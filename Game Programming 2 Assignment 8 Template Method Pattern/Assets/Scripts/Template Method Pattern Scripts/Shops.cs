/*
 * (Christopher Green)
 * (Shop.cs)
 * (Assignment 8)
 * (This script is the abstract superclass for the different shop types and it defnes how methods are executed by using its template method for execution.)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shops
{

    protected string greeting;
    protected string shopDescription;
    protected string shopType;
    protected string shopkeeperResponse;

    protected ShopTestDrive testDrive;

    public void Interact()
    {
        GetShopTestDriveReference();

        ChangeChoices();

        testDrive.actualTitleText.text = GetShopType();

        testDrive.actualBodyText.text = Greeting();

        if(wantsToHearDescription(testDrive.userResponse))
        {
            if(testDrive.inWeaponsShop)
            {
                testDrive.actualBodyText.text = ShopKeeperToUserResponse(testDrive.userResponse);
            }
            else if (testDrive.inMagicShop)
            {
                testDrive.actualBodyText.text = ShopKeeperToUserResponse(testDrive.userResponse);
            }
            else if(testDrive.inGeneralStoreShop)
            {
                testDrive.actualBodyText.text = ShopKeeperToUserResponse(testDrive.userResponse);
            }
        }
        else if(!wantsToHearDescription(testDrive.userResponse))
        {
            if (testDrive.inWeaponsShop)
            {
                testDrive.actualBodyText.text = ShopKeeperToUserResponse(testDrive.userResponse);
            }
            else if(testDrive.inMagicShop)
            {
                testDrive.actualBodyText.text = ShopKeeperToUserResponse(testDrive.userResponse);
            }
            else if(testDrive.inGeneralStoreShop)
            {
                testDrive.actualBodyText.text = ShopKeeperToUserResponse(testDrive.userResponse);
            }
        }
    }

    public void Buy(string item, int cost)
    {
        switch(item)
        {
            case "Inferno Scroll":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Freezing Winds Coat":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Crystal Ball":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Sword":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Battle Axe":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Bow and Arrows":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Apples":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Bundle of Wood":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;

            case "Clothes":
                testDrive.totalMoneyText.text = "Total Money: $" + PurchaseItem(cost);
                break;
        }
    }

    /// <summary>
    /// Abstract methods
    /// </summary>

    public abstract string GetShopType();

    public abstract string Greeting();

    public abstract string ShopDescription();

    public abstract void ChangeChoices();

    public abstract string ShopKeeperToUserResponse(bool isInShop);

    public abstract int PurchaseItem(int cost);

    /// <summary>
    /// My Hook
    /// </summary>
    public virtual bool wantsToHearDescription(bool userResponse)
    {
        userResponse = false;
        return userResponse;
    }

    /// <summary>
    /// General methods
    /// </summary>

    public void GetShopTestDriveReference()
    {
        testDrive = GameObject.Find("ShopkeeperTestDrive").GetComponent<ShopTestDrive>();
    }
}
