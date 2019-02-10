using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food 
{
    // array of all ndbnos
    public static string[] ALLNDBNOS = {
    "01239", "01187", "01110", "01042", "01116", "09299",
    "11364", "09265", "11049", "09040", "20121", "20453",
    "05067", "10857", "23266", "10984", "09422", "11450",
    "11177", "11969", "11868", "05673", "13849", "15241",
    "01223", "01028", "01270", "43274", "01057", "11248",
    "11311", "45359340", "11100", "09037", "09286", "20038",
    "20120", "20648", "20445", "20068", "10861", "23634",
    "17390", "17111", "16426", "15118", "09039", "11049",
    "11267", "11255", "11115", "20137", "20321", "20029",
    "20134", "05323", "45285752", "01131", "01119", "01236",
    "11439", "11549", "11147", "11080", "11233", "15137",
    "15034", "15171", "23274", "01264", "01023", "01104",
    "01128", "11026", "11118", "11091", "01040", "01102",
    "01077", "01081", "11457", "11745", "20523", "20310",
    "15220", "23353", "10068", "15077", "01092", "01133",
    "01218", "19207", "11938", "15038", "83110", "15085",
    "15072", "09520", "09250", "09205", "09316", "09430",
    "09150", "09213", "09125", "09410", "11540", "11931",
    "11956", "11740", "11965", "11378", "11300", "01224",
    "01140", "01123", "43276", "16108", "16049", "16030",
    "15158", "15012", "05028", "07929", "15230", "16156",
    "16155", "19407", "19412", "28290", "19040", "19059"
    };

    public static Dictionary<string, Food> ALLFOODS;
    

    // identifiers
    public string ndbno;
    public string name;
    public int price;

    // nutrients
    public float carbs;
    public float fat;
    public float protein;
    public float fiber;
    public float electrolytes;
    public float riboflavin;
    public float vitaminD;
    public float vitaminC;
    public float iron;
    public float calories;
   
    
    public Food(string ndbno) {
        string text = System.IO.File.ReadAllText("Assets/Data/" + ndbno + ".txt");
        string[] foodData = text.Split('|');

        this.ndbno = foodData[0];
        this.name = foodData[1];
        float.TryParse(foodData[2], out this.carbs);
        float.TryParse(foodData[3], out this.fat);
        float.TryParse(foodData[4], out this.protein);
        float.TryParse(foodData[5], out this.fiber);
        float.TryParse(foodData[6], out this.electrolytes);
        float.TryParse(foodData[7], out this.riboflavin);
        float.TryParse(foodData[8], out this.vitaminD);
        float.TryParse(foodData[9], out this.vitaminC);
        float.TryParse(foodData[10], out this.iron);
        float.TryParse(foodData[11], out this.calories);
        int.TryParse(foodData[12], out this.price); 
    }

    // Generates a map of ndbno:Food
    public static void GenerateAllFoods() {
        ALLFOODS = new Dictionary<string, Food>();
        for (int i = 0; i < ALLNDBNOS.Length; i++) {
            Food food = new Food(ALLNDBNOS[i]);
            ALLFOODS[ALLNDBNOS[i]] = food;
        }
    }

    // Returns a map of size n of random ndbno:Food
    public static Dictionary<string, Food> GenerateNFoods(int n) {
        Dictionary<string, Food> foods = new Dictionary<string, Food>();
        System.Random rnd = new System.Random();

        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < n; i++) {
            int idx = rnd.Next(ALLNDBNOS.Length);
            if (seen.Add(idx)) {
                foods[ALLNDBNOS[idx]] = ALLFOODS[ALLNDBNOS[idx]];
            } else {
                i--;
            }
        }

        return foods;
    }

    public Food getFood (string ndbno)
    {
        return ALLFOODS[ndbno];
    }
}
