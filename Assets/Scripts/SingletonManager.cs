using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    public Player player;
    
    public static SingletonManager Instance { get; private set; }

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        player = FindObjectOfType<Player>();
    }
}
