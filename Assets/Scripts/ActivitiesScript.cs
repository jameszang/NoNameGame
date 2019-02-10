using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivitiesScript : MonoBehaviour {
    
    public void ChangeScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    public void SlideOut(GameObject obj1, GameObject obj2, GameObject obj3, GameObject obj4)
    {
        ArrayList Activities = new ArrayList();
        Activities.Add(obj1);
        Activities.Add(obj2);
        Activities.Add(obj3);
        Activities.Add(obj4); 
        foreach (GameObject gameObject in Activities)
        {
            gameObject.transform.Translate(Vector3.right * 800);
        }
        
    }

    public void ChanghgjhgSe(GameObject obj1, GameObject obj2, GameObject obj3, GameObject obj4)
    {
        ArrayList Activities = new ArrayList();
        Activities.Add(obj1);
        Activities.Add(obj2);
        Activities.Add(obj3);
        Activities.Add(obj4);

        foreach (GameObject gameObject in Activities)
        {
            gameObject.transform.Translate(Vector3.right * 800);
        }
    }


}
