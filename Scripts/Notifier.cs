using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier : MonoBehaviour
{


    public delegate void mensaje();
    public event mensaje OnRecolect;


    void Update() {
        /*
        contador += 1;
        if (contador % 1000 == 0)
            OnMensaje();

        */
        transform.Rotate(0, 0, 300 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            OnRecolect();
            Destroy(gameObject);
        }
        
    }

}
