using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fridge : MonoBehaviour {
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

    public void OpenCloseFridge() {
        if (SceneManager.GetActiveScene().name == "Supermarket") {
            if (isInside) {
                animator.Play("FridgeSlideLeft");
            } else {
                animator.Play("FridgeSlideRight");
            }
        } else {
            if (isInside) {
                animator.Play("FridgeSlideDown");
            } else {
                animator.Play("FridgeSlideUp");
            }
        }
        isInside = !isInside;
    }

    public void CloseFridge() {
        if (isInside) {
            if (SceneManager.GetActiveScene().name == "Supermarket") {
                animator.Play("FridgeSlideLeft");
            } else {
                animator.Play("FridgeSlideDown");
            }
            isInside = !isInside;
        }
    }
}
