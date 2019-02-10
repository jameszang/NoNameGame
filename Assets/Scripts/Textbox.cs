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

 
    public void ToggleTextbox()
    {
        if (display == false)
        {
            textbox.SetActive(true);
            display = true; 
        }
        else  {
            textbox.SetActive(false);
            display = false; 
        }
        
    }
}
