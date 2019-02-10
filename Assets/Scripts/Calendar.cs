using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : MonoBehaviour
{

    public static int day = 0;
    private static UnityEngine.UI.Text text;

    private void Awake() {
        text = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            day++;
            if (day > 31) {
                day = 1;
            }
            text.text = day.ToString();
        }
    }
}
