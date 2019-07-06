using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFood : MonoBehaviour
{
    public int index; // 0-19 inclusive, used to get the Food item from DayManager.foodInSupermarket[index]

    public void test() {
        Debug.Log("bought some " + DayManager.foodInSupermarket[index].name);

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
