using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopTestDrive : MonoBehaviour
{
    public Text actualBodyText;
    public Text actualTitleText;

    public GameObject purchaseButtonChoices;
    public GameObject shopButtonChoices;
    public Button choiceOne;
    public Button choiceTwo;
    public Button choiceThree;

    MagicShop magicShop;
    WeaponsShop weaponsShop;

    public bool userResponse;
    public bool inWeaponsShop;
    public bool inMagicShop;

    Shops shops;


    // Start is called before the first frame update
    void Start()
    {
        magicShop = new MagicShop();
        weaponsShop = new WeaponsShop();

        actualBodyText.text = "Would you like to hear the descriptions of the shops (Y/N)?";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            userResponse = true;

            Debug.Log("The user said yes!");
        }
        else if(Input.GetKeyDown(KeyCode.N))
        {
            userResponse = false;

            Debug.Log("The user said no!");
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void SetShop(string shop)
    {
        switch(shop)
        {
            case "Weapons":
                //weaponsShop = new WeaponsShop();
                inWeaponsShop = true;
                inMagicShop = false;
                weaponsShop.Interact();
                break;
            case "Magic":
                //magicShop = new MagicShop();
                inWeaponsShop = false;
                inMagicShop = true;
                magicShop.Interact();
                break;
        }
    }

}
