using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicShop : Shops
{

    private string shopDescription;
    private string shopType;

    public override void ChangeChoices()
    {
        testDrive.shopButtonChoices.SetActive(false);
        testDrive.purchaseButtonChoices.SetActive(true);
        testDrive.choiceOne.transform.GetChild(0).GetComponent<Text>().text = "Inferno Pire";
        testDrive.choiceTwo.transform.GetChild(0).GetComponent<Text>().text = "Freezing Winds";
        testDrive.choiceThree.transform.GetChild(0).GetComponent<Text>().text = "Crystal Ball";
    }

    public override string GetShopType()
    {
        shopType = "Magic";
        return shopType;
    }

    public override string ShopDescription()
    {
        shopDescription = "Hello, my name is Ezra and welcome to _____! The end to all your arcane needs.";
        return shopDescription;
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
