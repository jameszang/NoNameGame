using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour {
    public Player player;
    public string statName;
    public float minX;
    public float maxX;

    private RectTransform rectTransform;

    void Start() {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Stat stat = player.GetStatByName(statName);
        float newXPos = stat.getCurr() * ((minX + maxX) / (stat.getAbsMin() + stat.getAbsMax()));
        rectTransform.anchoredPosition = new Vector2(newXPos, rectTransform.anchoredPosition.y);
    }
}
