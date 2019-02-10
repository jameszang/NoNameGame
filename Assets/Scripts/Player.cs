using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // public instance variables
    public int spd;

    // private instance variables
    // major stats
    private Stat health;
    private Stat satiation;
    private Stat stamina;
    private int money;

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
    void Start() {
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
    }

    // Update is called once per frame
    void Update() {
        
    }
}
