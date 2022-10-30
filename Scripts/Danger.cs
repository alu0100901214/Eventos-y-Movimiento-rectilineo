using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{

    public GameManager gameManager;
    public int value = 5;

    private Vector3 direction;

    void Update() {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            gameManager.health -= value;
            direction = other.gameObject.transform.position - this.transform.position;
            other.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * 3000);
        }
        
    }
}
