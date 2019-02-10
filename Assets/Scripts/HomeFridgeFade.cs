using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeFridgeFade : MonoBehaviour
{
    private Animator animator;
    private bool isShown;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isShown = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FridgeFadeIn()
    {
        if (isShown)
        {
            animator.Play("HomeFridgeFade");

        }
        else
        {
            animator.Play("HomeFridgeFadeOut");
        }
        isShown = !isShown;
    }
}
