using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFood : MonoBehaviour
{
    public void test() {
        Debug.Log("bought some food");

        // remove the sprite and make the alpha 0 (transparent)
        Image image = GetComponent<Image>();
        image.sprite = null;

        Color tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;

        // can't buy something that's not there
        Button buyButton = GetComponent<Button>();
        buyButton.interactable = false;
    }
}
