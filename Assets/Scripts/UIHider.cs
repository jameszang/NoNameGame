using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHider : MonoBehaviour
{
    UnityEngine.UI.Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Supermarket") {
            img.color = new Color(255, 255, 255, 0);
        } else {
            img.color = new Color(255, 255, 255, 255);
        }
    }
}
