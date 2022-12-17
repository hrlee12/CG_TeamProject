using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    public GameObject Pivot;

    // Start is called before the first frame update
    void Start()
    {
        print("AutoDoor script start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Enter : " + other.gameObject.name);
        if (other.tag == "Player") {
            Pivot.GetComponent<Animator>().SetInteger("State", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exit : " + other.gameObject.name);
        if (other.tag == "Player") {
            Pivot.GetComponent<Animator>().SetInteger("State", 2);
        }
    }
}