using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MeatHandler : MonoBehaviour
{
    Player player;

    private void Awake() {
        player = FindObjectOfType<Player>();
    }

    public void Handle(string ndbno) {
        if (SceneManager.GetActiveScene().name == "Supermarket") {
            // add to fridge
            Debug.Log("added to fridge");
            player.pay(Food.ALLFOODS[ndbno].price);
            player.addToInventory(ndbno);
        } else {
            Debug.Log("eaten");
            player.takeFromInventory(ndbno);
            GameObject.Destroy(gameObject);
        }
    }
}
