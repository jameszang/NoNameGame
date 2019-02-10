using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHider : MonoBehaviour
{
    Component[] imgs;
    // Start is called before the first frame update
    void Start()
    {
        imgs = GetComponentsInChildren<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Supermarket") {
            foreach (UnityEngine.UI.Image img in imgs) {
                Color temp = img.color;
                temp.a = 0f;
                img.color = temp;
            }
        } else {
            foreach (UnityEngine.UI.Image img in imgs) {
                Color temp = img.color;
                temp.a = 255f;
                img.color = temp;
            }
        }
    }
}
