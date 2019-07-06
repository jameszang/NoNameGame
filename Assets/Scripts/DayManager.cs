using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    public static int day = 0;
    public static Food[] foodInSupermarket = new Food[20];

    private static UnityEngine.UI.Text text;

    public Shelf shelf;
    public ProductInfoDisplay productInfoDisplay;

    private void Awake() {
        text = GetComponent<UnityEngine.UI.Text>();
        // Start at day 0 and call NextDay() to generate food in supermarket
        NextDay();
    }

    // Update is called once per frame
    void Update() {

    }

    public void NextDay() {
        day++;
        if (day > 31) {
            day = 1;
        }
        text.text = day.ToString();

        Dictionary<string, Food> fruits = Food.GenerateNFoodsWithFoodGroup(4, "Fruit");
        Dictionary<string, Food> veggies = Food.GenerateNFoodsWithFoodGroup(4, "Vegetable");
        Dictionary<string, Food> meats = Food.GenerateNFoodsWithFoodGroup(4, "Meat");
        Dictionary<string, Food> wheats = Food.GenerateNFoodsWithFoodGroup(4, "Wheat");
        Dictionary<string, Food> junks = Food.GenerateNFoodsWithFoodGroup(4, "Junk");

        int idx = 0;
        foreach (KeyValuePair<string, Food> pair in fruits) {
            foodInSupermarket[idx] = pair.Value;
            idx++;
        }

        foreach (KeyValuePair<string, Food> pair in veggies) {
            foodInSupermarket[idx] = pair.Value;
            idx++;
        }

        foreach (KeyValuePair<string, Food> pair in meats) {
            foodInSupermarket[idx] = pair.Value;
            idx++;
        }

        foreach (KeyValuePair<string, Food> pair in wheats) {
            foodInSupermarket[idx] = pair.Value;
            idx++;
        }

        foreach (KeyValuePair<string, Food> pair in junks) {
            foodInSupermarket[idx] = pair.Value;
            idx++;
        }

        shelf.resetStock();
        productInfoDisplay.resetDisplay();
    }
}
