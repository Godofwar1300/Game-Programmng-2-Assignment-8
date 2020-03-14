/*
 * (Christopher Green)
 * (ShopTestDrive.cs)
 * (Assignment 8)
 * (This script handles basic testing functionality for running the Template Method Pattern.)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopTestDrive : MonoBehaviour
{
    [Header("Body and Title Text")]
    public Text actualBodyText;
    public Text actualTitleText;
    public Text gameoverBodyText;

    [Header("Total Money")]
    public int totalMoney;
    public Text totalMoneyText;

    [Header("Total Items To Buy")]
    public int itemsAbleToBuy;
    public Text itemsAbleToBuyText;

    [Header("Purchase Options")]
    public GameObject WeaponPurchaseChoicesButton;
    public GameObject magicPurshaseChoicesButton;
    public GameObject generalGoodsPurshaseChoiceButton;
    public Button choiceOne;
    public Button choiceTwo;
    public Button choiceThree;

    [Header("Shop Stuff")]
    public GameObject shopButtonChoices;
    MagicShop magicShop;
    WeaponsShop weaponsShop;
    GeneralGoodsShop generalGoodsShop;

    [Header("Bools")]
    public bool canInput;
    public bool userResponse;
    public bool inWeaponsShop;
    public bool inMagicShop;
    public bool inGeneralStoreShop;

    [Header("Strings")]
    public string descriptionPrompt = "Would you like to hear the descriptions of the shops (Y/N)?";
    public string userInputString;

    [Header("Menus")]
    public GameObject gameOverMenu;


    // Start is called before the first frame update
    void Start()
    {

        gameOverMenu.SetActive(false);

        canInput = true;
        magicShop = new MagicShop();
        weaponsShop = new WeaponsShop();
        generalGoodsShop = new GeneralGoodsShop();

        actualBodyText.text = descriptionPrompt;

        totalMoney = 2500;
        itemsAbleToBuy = 0;

        totalMoneyText.text = "Total Money: $" + totalMoney;
        itemsAbleToBuyText.text = "Total Items: " + itemsAbleToBuy;

    }

    // Update is called once per frame
    void Update()
    {
        GetUserInput();

        itemsAbleToBuyText.text = "Total Items: " + itemsAbleToBuy;

        if(itemsAbleToBuy == 5 || totalMoney < 1000)
        {
            gameOverMenu.SetActive(true);

            if(totalMoney < 1000)
            {
                gameoverBodyText.text = "Awww....I spent too much...now I won't have enough to buy passage overseas for me and my family\n\n YOU LOST";
            }
            else
            {
                gameoverBodyText.text = "Great! Now that I have my supplies and enough money left over I can travel without worry! \n\n YOU WIN";
            }

        }

    }

    // Button that the user presses to pick what shop they want to enter
    public void SetShop(string shop)
    {
        switch (shop)
        {
            case "Weapons":
                inWeaponsShop = true;
                inGeneralStoreShop = false;
                inMagicShop = false;
                weaponsShop.Interact();
                break;
            case "Magic":
                inWeaponsShop = false;
                inGeneralStoreShop = false;
                inMagicShop = true;
                magicShop.Interact();
                break;
            case "General Store":
                inWeaponsShop = false;
                inMagicShop = false;
                inGeneralStoreShop = true;
                generalGoodsShop.Interact();                
                break;
        }
    }

    public void BuyItems(string purchaseitem)
    {
        switch (purchaseitem)
        {
            case "Inferno Scroll":
                string itemToBuy = "Inferno Scroll";
                magicShop.Buy(itemToBuy, 250);
                itemsAbleToBuy++;
                break;
            case "Freezing Winds Coat":
                itemToBuy = "Freezing Winds Coat";
                magicShop.Buy(itemToBuy, 600);
                itemsAbleToBuy++;
                break;

            case "Crystal Ball":
                itemToBuy = "Crystal Ball";
                magicShop.Buy(itemToBuy, 150);
                itemsAbleToBuy++;
                break;

            case "Sword":
                itemToBuy = "Sword";
                weaponsShop.Buy(itemToBuy, 200);
                itemsAbleToBuy++;
                break;

            case "Battle Axe":
                itemToBuy = "Battle Axe";
                weaponsShop.Buy(itemToBuy, 350);
                itemsAbleToBuy++;
                break;

            case "Bow and Arrows":
                itemToBuy = "Bow and Arrows";
                weaponsShop.Buy(itemToBuy, 150);
                itemsAbleToBuy++;
                break;
            case "Apples":
                itemToBuy = "Apples";
                generalGoodsShop.Buy(itemToBuy, 5);
                itemsAbleToBuy++;
                break;

            case "Bundle of Wood":
                itemToBuy = "Bundle of Wood";
                generalGoodsShop.Buy(itemToBuy, 125);
                itemsAbleToBuy++;
                break;

            case "Clothes":
                itemToBuy = "Clothes";
                generalGoodsShop.Buy(itemToBuy, 25);
                itemsAbleToBuy++;
                break;
        }
    }


    // Method that gets the users input and does the appropriate stuff
    public void GetUserInput()
    {
        if (Input.GetKeyDown(KeyCode.Y) && canInput)
        {
            canInput = false;
            userResponse = true;
            userInputString = descriptionPrompt + "\n\nYou Typed Yes!";

            actualBodyText.text = userInputString;
        }
        else if (Input.GetKeyDown(KeyCode.N) && canInput)
        {
            canInput = false;
            userResponse = false;
            userInputString = descriptionPrompt + "\n\nYou Typed No!";

            actualBodyText.text = userInputString;
        }
    }

}
