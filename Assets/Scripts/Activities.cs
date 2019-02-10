using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities : MonoBehaviour
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

    public void ActivitiesSlideLeft()
    {
        if (isInside)
        {
            //FridgeSlideLeft
            animator.Play("ActivitiesSlideRight");
        }
        else
        {
            animator.Play("ActivitiesSlideLeft");
        }
        isInside = !isInside;
    }
}
