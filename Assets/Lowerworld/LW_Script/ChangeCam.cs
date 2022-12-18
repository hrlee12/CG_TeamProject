using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeCam : MonoBehaviour
{
    public Camera DefCam;
    public Camera ShaderCam;

    // Start is called before the first frame update
    void Start()
    {
        ShaderCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShaderCam.enabled = true;
            DefCam.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            DefCam.enabled = true;
            ShaderCam.enabled = false;
        }
    }
}
