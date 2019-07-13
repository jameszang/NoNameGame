using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour 
{
    // The 9 InventoryItem objects that are children of Fridge
    public InventoryItem[] inventoryItems;

    // instance variables
    public int spd;

    // major stats
    private Stat health;
    private Stat satiation;
    private Stat stamina;
    private int money;

    //inventory is an array of ndbnos
    private string[] inventory;
    private readonly int inventoryLimit = 9;
    private int numItemsInInventory = 0;

    public bool AddToInventory(string ndbno)
    {
        if (numItemsInInventory < inventoryLimit) {
            // find first free space in inventory
            int firstFreeIndex = -1;
            for (int i = 0; i < inventoryLimit; i++) {
                if (inventory[i] == "") {
                    firstFreeIndex = i;
                    break;
                }
            }
            inventory[firstFreeIndex] = ndbno;
            numItemsInInventory++;

            Image image = inventoryItems[firstFreeIndex].gameObject.GetComponent<Image>();
            image.sprite = Resources.Load<Sprite>("Sprites/FoodIcons/" + Food.ALLFOODS[ndbno].foodGroup.ToLower());

            Color tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;

            // make the button clickable
            Button buyButton = inventoryItems[firstFreeIndex].gameObject.GetComponent<Button>();
            buyButton.interactable = true;
            return true;
        } else {
            return false;
        }
        
    }

    public bool TakeFromInventory(int index)
    {
        if (satiation.getCurr() >= satiation.getAbsMax()) {
            return false;
        }

        string ndbnoToConsume = inventory[index];
        if (ndbnoToConsume == "") {
            return false;
        }

        Food food = Food.ALLFOODS[ndbnoToConsume];
        Eat(food);
        inventory[index] = "";
        numItemsInInventory--;
        return true;
    }

    private void Eat(Food food)
    {
        carbs.add(food.carbs);
        fat.add(food.fat);
        protein.add(food.protein);
        fiber.add(food.fiber);
        electrolytes.add(food.electrolytes);
        riboflavin.add(food.riboflavin);
        vitaminD.add(food.vitaminD);
        vitaminC.add(food.vitaminC);
        iron.add(food.iron);
        calories.add(food.calories);
    }

    // detailed stats
    private Stat carbs;
    private Stat fat;
    private Stat protein;
    private Stat fiber;
    private Stat electrolytes;
    private Stat riboflavin;
    private Stat vitaminD;
    private Stat vitaminC;
    private Stat iron;
    private Stat calories;

    // Start is called before the first frame update
    void Awake() {
        this.health = new Stat("health", 0, 100, 30, 100);
        this.satiation = new Stat("satiation", 0, 100, 30, 70);
        this.stamina = new Stat("stamina", 0, 100, 0, 100);
        this.money = 1000;

        this.carbs = new Stat("carbs", 0, 100, 45, 65); // % daily calorie intake
        this.fat = new Stat("fat", 0, 100, 20, 30); // % daily calorie intake
        this.protein = new Stat("protein", 0, 100, 10, 30); // % daily calorie intake
        this.fiber = new Stat("fiber", 0, 100, 25, 100); // grams
        this.electrolytes = new Stat("electrolytes", 0, 15000, 4100, 10100); // mg
        this.riboflavin = new Stat("riboflavin", 0, 5, 1.1f, 5); // mg
        this.vitaminD = new Stat("vitaminD", 0, 0.05f, 0.015f, 0.05f); // mg
        this.vitaminC = new Stat("vitaminC", 0, 3000, 75, 2000); // mg
        this.iron = new Stat("iron", 0, 70, 8, 45); // mg
        this.calories = new Stat("calories", 0, 4000, 1500, 2500); // calories

        this.inventory = new string[inventoryLimit];
        for (int i = 0; i < inventoryLimit; i++) {
            this.inventory[i] = "";
        }
    }

    private void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public Stat GetStatByName(string name) {
        switch (name) {
            case "health":
                return health;
            case "satiation":
                return satiation;
            case "stamina":
                return stamina;
            case "carbs":
                return carbs;
            case "fat":
                return fat;
            case "protein":
                return protein;
            case "fiber":
                return fiber;
            case "electrolytes":
                return electrolytes;
            case "riboflavin":
                return riboflavin;
            case "vitaminD":
                return vitaminD;
            case "vitaminC":
                return vitaminC;
            case "iron":
                return iron;
            default:
                return calories;
        }
    }

    public int GetMoney()
    {
        return this.money;
    }

    public void Pay(int priceToPay)
    {
        this.money = this.money - priceToPay; 
    }
}
