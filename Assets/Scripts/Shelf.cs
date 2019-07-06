using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shelf : MonoBehaviour
{
    public ShelfItem[] children;

    public void resetStock() {
        for (int i = 0; i < children.Length; i++) {
            //sanity check
            if (i >= DayManager.foodInSupermarket.Length) {
                break;
            }

            // change the image to the appropriate food icon
            Image image = children[i].gameObject.GetComponent<Image>();
            image.sprite = Resources.Load<Sprite>("Sprites/FoodIcons/" + DayManager.foodInSupermarket[i].foodGroup.ToLower());

            Color tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;

            // make the button clickable
            Button buyButton = children[i].gameObject.GetComponent<Button>();
            buyButton.interactable = true;
        }
    }

    public void BuyFood(int index) {
        children[index].BecomePurchased();
    }
}
