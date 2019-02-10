using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductFade : MonoBehaviour
{
    private Animator animator;
    private bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowProductInfo()
    {
        if (isClicked)
        {
            animator.Play("ShowProduct");
        }
    }
}
