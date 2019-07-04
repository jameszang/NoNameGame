﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ActivitiesScript : MonoBehaviour {

    public GameObject player;
    public Fridge fridge;
    public GameObject fridgeButton;

    public void ChangeScene(string scene) {
        if (SceneManager.GetActiveScene().name != scene) {
            fridge.CloseFridge();
            StartCoroutine(loadYourSceneAsync(scene));
        }
    }

    IEnumerator loadYourSceneAsync(string scene) {
        Scene currentScene = SceneManager.GetActiveScene();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
        while (!asyncLoad.isDone) {
            yield return null;
        }
        SceneManager.MoveGameObjectToScene(player, SceneManager.GetSceneByName(scene));
        SceneManager.MoveGameObjectToScene(FindObjectOfType<Canvas>().gameObject, SceneManager.GetSceneByName(scene));
        SceneManager.MoveGameObjectToScene(FindObjectOfType<EventSystem>().gameObject, SceneManager.GetSceneByName(scene));

        // Set certain parts of UI to active based on scene
        if (scene != "Home") {
            player.SetActive(false);
        } else {
            player.SetActive(true);
        }

        if (scene == "Home" || scene == "Supermarket") {
            fridgeButton.SetActive(true);
        } else {
            fridgeButton.SetActive(false);
        }

        SceneManager.UnloadSceneAsync(currentScene);
    }

    //Logic for moving activities menu out of the way
    public void SlideOut(GameObject Activity)
    {
            Activity.transform.Translate(Vector3.right * 800);
        
    }
}
