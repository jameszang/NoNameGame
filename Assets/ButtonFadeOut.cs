using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFadeOut : MonoBehaviour
{
    private Animator animator;
    private bool isClicked;
    public string animations;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isClicked = false;
    }

    // Update is called once per frame
    void Update() {
        animator.Play(animations);
    }

    public void ShowProductInfo()
    {
        animator.Play(animations);
    }
}
