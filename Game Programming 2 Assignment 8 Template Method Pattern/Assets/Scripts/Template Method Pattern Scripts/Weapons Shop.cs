using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponsShop : Shops
{

    private string shopDescription;
    private string shopType;

    public override void ChangeChoices()
    {
        testDrive.shopButtonChoices.SetActive(false);
        testDrive.purchaseButtonChoices.SetActive(true);
        testDrive.choiceOne.transform.GetChild(0).GetComponent<Text>().text = "Sword";
        testDrive.choiceTwo.transform.GetChild(0).GetComponent<Text>().text = "Battle Axe";
        testDrive.choiceThree.transform.GetChild(0).GetComponent<Text>().text = "Bow and Arrows";
    }

    public override string GetShopType()
    {
        shopType = "Weapons";
        return shopType;
    }

    public override string ShopDescription()
    {
        shopDescription = "Buy something or get out, before I crush your puny skull";
        return shopDescription;
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
