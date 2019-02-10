using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextHider : MonoBehaviour
{
    Component[] texts;
    // Start is called before the first frame update
    void Start() {
        texts = GetComponentsInChildren<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update() {
        if (SceneManager.GetActiveScene().name == "Supermarket") {
            foreach (UnityEngine.UI.Text text in texts) {
                text.fontSize = 0;
            }
        } else {
            foreach (UnityEngine.UI.Text text in texts) {
                text.fontSize = 150;
            }
        }
    }
}
