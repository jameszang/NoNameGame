using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryItem : MonoBehaviour
{
    public int index; // 0-8 inclusive
    public Player player;

    public void GetEaten() {
        if (SceneManager.GetActiveScene().name != "Home") {
            return;
        }
    
        bool successfulEat = player.TakeFromInventory(index);

        if (successfulEat) {
            // remove the sprite and make the alpha 0 (transparent)
            Image image = GetComponent<Image>();
            image.sprite = null;

            Color tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;

            // can't eat something that's not there
            Button eatButton = GetComponent<Button>();
            eatButton.interactable = false;
        }
    }
}
