using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFall : MonoBehaviour
{
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0.0f;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSYellow")
            Anim.speed = 1.0f;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSYellow")
            Anim.speed = 0.0f;
    }
}

