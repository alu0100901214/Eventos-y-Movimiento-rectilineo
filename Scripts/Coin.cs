using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public GameManager gameManager;
    public int value = 1;

    void Update() {
        transform.Rotate(0, 300 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            gameManager.coins += value;
            Destroy(gameObject);
        }
        
    }
}
