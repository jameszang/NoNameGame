using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivitiesScript : MonoBehaviour {


    public void ChangeScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    public void SlideOut(List<GameObject> Activities)
    { 

        foreach (GameObject gameObject in Activities)
        {
            gameObject.transform.Translate(Vector3.right * 800);
        }
        
    }
}
