using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour 
{
    private void Awake() {
        Random.InitState(System.DateTime.UtcNow.Second);
        Food.GenerateAllFoods();
    }
}
