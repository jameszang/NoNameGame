using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ActivitiesScript : MonoBehaviour {

    public Fridge fridge;
    public GameObject player;
    public GameObject[] allButHomeUI;
    public GameObject[] homeAndSupermarketUI;
    public GameObject[] homeUI;
    public GameObject[] supermarketUI;
    public GameObject[] restaurantUI;

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

        // Set player to active if on the home scene
        if (scene != "Home") {
            player.SetActive(false);
        } else {
            player.SetActive(true);
        }

        // Set certain parts of UI to active based on scene
        foreach (GameObject obj in allButHomeUI) {
            if (scene != "Home") {
                obj.SetActive(true);
            } else {
                obj.SetActive(false);
            }
        }

        foreach (GameObject obj in homeAndSupermarketUI) {
            if (scene == "Home" || scene == "Supermarket") {
                obj.SetActive(true);
            } else {
                obj.SetActive(false);
            }
        }

        foreach (GameObject obj in homeUI) {
            if (scene == "Home") {
                obj.SetActive(true);
            } else {
                obj.SetActive(false);
            }
        }

         foreach (GameObject obj in supermarketUI) {
            if (scene == "Supermarket") {
                obj.SetActive(true);
            } else {
                obj.SetActive(false);
            }
        }

        foreach (GameObject obj in restaurantUI) {
            if (scene == "Restaurant") {
                obj.SetActive(true);
            } else {
                obj.SetActive(false);
            }
        }

        SceneManager.UnloadSceneAsync(currentScene);
    }

    //Logic for moving activities menu out of the way
    public void SlideOut(GameObject Activity)
    {
            Activity.transform.Translate(Vector3.right * 800);
        
    }
}
