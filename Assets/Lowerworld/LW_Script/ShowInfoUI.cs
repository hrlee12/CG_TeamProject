using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfoUI : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        print("ShowInfoUI script start");
        obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (obj.activeSelf == true) {
                obj.SetActive(false);
            }
            else {
                obj.SetActive(true);
            }
        }
    }
}
