using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ActivitiesScript : MonoBehaviour {

    public void ChangeScene(string scene) {
        StartCoroutine(loadYourSceneAsync(scene));
    }

    IEnumerator loadYourSceneAsync(string scene) {
        Scene currentScene = SceneManager.GetActiveScene();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
        while (!asyncLoad.isDone) {
            yield return null;
        }
        SceneManager.MoveGameObjectToScene(FindObjectOfType<Player>().gameObject, SceneManager.GetSceneByName(scene));
        SceneManager.MoveGameObjectToScene(FindObjectOfType<Canvas>().gameObject, SceneManager.GetSceneByName(scene));
        SceneManager.MoveGameObjectToScene(FindObjectOfType<EventSystem>().gameObject, SceneManager.GetSceneByName(scene));
        SceneManager.UnloadSceneAsync(currentScene);
    }

    //Logic for moving activities menu out of the way
    public void SlideOut(GameObject Activity)
    {
            Activity.transform.Translate(Vector3.right * 800);
        
    }
}
