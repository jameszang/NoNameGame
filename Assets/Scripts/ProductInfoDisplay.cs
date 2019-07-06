using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductInfoDisplay : MonoBehaviour
{
    public Text foodName;
    public Text foodInfo;
    public GameObject buyFoodButton;
    public Shelf shelf;

    private int indexSelected;

    public void ResetDisplay() {
        foodName.text = "Food name will be displayed here";
        foodInfo.text = "Click a food to see some of it's information before buying";
        buyFoodButton.SetActive(false);
    }

    // the index param is the index to be used in DayManager.foodInSupermarket[index] (i.e., the position on the shelf)
    public void GetAndDisplayInfo(int index) {
        indexSelected = index;
        Food currentFood = DayManager.foodInSupermarket[index];

        foodName.text = currentFood.name;
        foodInfo.text = 
            "Carbohydrates: " + currentFood.carbs + "g\n" +
            "Fat: " + currentFood.fat + "g\n" +
            "Protein: " + currentFood.protein + "g\n" +
            "Fiber: " + currentFood.fiber + "g\n" + 
            "Electrolytes: " + currentFood.electrolytes + "mg\n" +
            "Riboflavin: " + currentFood.riboflavin + "mg\n" + 
            "Vitamin D: " + currentFood.vitaminD + "micrograms\n" +
            "Vitamin C: " + currentFood.vitaminC + "mg\n" +
            "Iron: " + currentFood.iron + "mg\n" +
            "Calories: " + currentFood.calories + "\n";
        buyFoodButton.SetActive(true);
    }

    public void BuyFood() {
        shelf.BuyFood(indexSelected);
        indexSelected = -1;
        ResetDisplay();
    }
}
