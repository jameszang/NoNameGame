using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivate : MonoBehaviour
{
    public GameObject canvas;
    public GameObject player;

    public void ToggleCanvas()
    {
        canvas.SetActive(true);
        player.SetActive(true);
    }

}


