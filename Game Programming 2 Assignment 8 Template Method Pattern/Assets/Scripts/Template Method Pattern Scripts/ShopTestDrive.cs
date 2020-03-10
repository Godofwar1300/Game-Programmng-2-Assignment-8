using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTestDrive : MonoBehaviour
{
    public Text actualBodyText;
    public Text actualTitleText;

    MagicShop magicShop;
    WeaponsShop weaponsShop;


    // Start is called before the first frame update
    void Start()
    {
        //shops.bodyText = actualBodyText.GetComponent<Text>();
        //shops.shopTitleText = actualTitleText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetShop(string shop)
    {
        switch(shop)
        {
            case "Weapons":
                weaponsShop = new WeaponsShop();
                weaponsShop.Interact();
                break;
            case "Magic":
                magicShop = new MagicShop();
                magicShop.Interact();
                break;
        }
    }

}
