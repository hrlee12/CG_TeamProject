using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowObjNameOnUI : MonoBehaviour
{
    // 참고 : https://coding-server.tistory.com/m/7
    private RaycastHit hit;
    public TMP_Text logtext;

    // Start is called before the first frame update
    void Start()
    {
        print("ShowObjNameOnUI script start");
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
    }

    void Raycast()
    {
        if (Physics.Raycast(this.transform.position, transform.forward, out hit))
        {
            if (hit.collider.name != "Terrain") {
                print("hit point : " + hit.point + ", distance : " + hit.distance + ", name : " + hit.collider.name);
                logtext.text = hit.collider.name;
            }
            else {
                logtext.text = "Press 'I' for Scene Info";
            }
        }
        else {
            logtext.text = "Press 'I' for Scene Info";
        }
    }
}
