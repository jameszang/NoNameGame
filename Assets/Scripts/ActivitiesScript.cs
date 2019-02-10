using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivitiesScript : MonoBehaviour {


    public void ChangeScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    //Logic for moving activities menu out of the way
    public void SlideOut(GameObject Activity)
    {
            Activity.transform.Translate(Vector3.right * 800);
        
    }
}
