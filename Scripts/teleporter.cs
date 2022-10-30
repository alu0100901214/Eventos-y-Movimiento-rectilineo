using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{

    public GameObject otherTeleporter;

    public bool teleporterExit = true;

    private void OnTriggerEnter(Collider other) {
        if(teleporterExit){
            otherTeleporter.GetComponent<teleporter>().teleporterExit = false;
            other.transform.position = otherTeleporter.transform.position;
        }
    }

    private void OnTriggerExit(Collider other) {
        teleporterExit = true;
    }

}
