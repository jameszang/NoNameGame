using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsNutrition : MonoBehaviour
{
    private Animator animator;
    private bool isInside;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isInside = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StatsSlideRight()
    {
        if (isInside)
        {
            //FridgeSlideLeft
            animator.Play("StatsSlideLeft");
        }
        else
        {
            animator.Play("StatsSlideRight");
        }
        isInside = !isInside;
    }
}
