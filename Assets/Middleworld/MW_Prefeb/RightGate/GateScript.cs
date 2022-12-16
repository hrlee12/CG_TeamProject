using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public GameObject Gate;
    private void OnTriggerEnter(Collider other)
    {
        Gate.GetComponent<Animator>().SetInteger("state", 1);
    }
    private void OnTriggerExit(Collider other)
    {
        Gate.GetComponent<Animator>().SetInteger("state", 2);
    }
}
