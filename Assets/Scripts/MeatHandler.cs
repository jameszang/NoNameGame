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
            player.Pay(Food.ALLFOODS[ndbno].price);
            player.AddToInventory(ndbno);
        } else {
            Debug.Log("eaten");
            //player.TakeFromInventory(ndbno);
            GameObject.Destroy(gameObject);
        }
    }
}
