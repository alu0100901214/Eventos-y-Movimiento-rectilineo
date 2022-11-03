using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public Notifier notificador;
    public int force = 1000;
    void Start()
    {
        notificador.OnRecolect += addForceToBall;
    }

    void addForceToBall()
    {
        GetComponent<Rigidbody>().AddForce(0, force, force);
    }
}
