using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{

    public static int day = 1;
    private static UnityEngine.UI.Text text;

    private void Awake() {
        text = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void NextDay() {
        Debug.Log("next day");
        day++;
        if (day > 31) {
            day = 1;
        }
        text.text = day.ToString();
    }
}
