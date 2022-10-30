using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolect : MonoBehaviour
{

    public GameObject Sphere1;
    public GameObject Sphere2;
    public GameObject Sphere3;

    public int force = 1000;

    void Update() {
        transform.Rotate(0, 0, 300 * Time.deltaTime);
    }

        private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            Sphere1.GetComponent<Rigidbody>().AddForce(0, force, force);
            Sphere2.GetComponent<Rigidbody>().AddForce(0, force, force);
            Sphere3.GetComponent<Rigidbody>().AddForce(0, force, force);
            Destroy(gameObject);
        }
        
    }

}
