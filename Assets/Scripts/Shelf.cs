using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shelf : MonoBehaviour
{
    public void resetStock() {
        int idx = 0;
        foreach (Transform child in transform) {
            // sanity check
            if (idx >= DayManager.foodInSupermarket.Length) {
                break;
            }

            // change the image to the appropriate food icon
            Image image = child.GetComponent<Image>();
            image.sprite = Resources.Load<Sprite>("Sprites/FoodIcons/" + DayManager.foodInSupermarket[idx].foodGroup.ToLower());

            Color tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;

            // make the button clickable
            Button buyButton = child.GetComponent<Button>();
            buyButton.interactable = true;
            idx++;
        }
    }
}
