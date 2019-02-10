using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textbox : MonoBehaviour
{
    public GameObject textbox;
    private bool display;
    // Start is called before the first frame update
    void Start()
    {
        display = false;
        textbox.SetActive(false);
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("D was pressed");
            if (display == true) {
                textbox.SetActive(false);
                display = false;
            } else {
                display = true;
                textbox.SetActive(true);
            }
        }
    }
}
