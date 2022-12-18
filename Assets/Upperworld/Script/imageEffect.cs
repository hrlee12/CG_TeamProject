using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class imageEffect : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial;


    public GameObject toggle_depth;
    public GameObject toggle_invert;


    bool isOn_depth;
    bool isOn_invert;


    // Start is called before the first frame update
    void Start()
    {
        toggle_depth.GetComponent<Toggle>().isOn = false;
        toggle_invert.GetComponent<Toggle>().isOn = false;


        myShader = Shader.Find("my/imageEffect");
        myMaterial = new Material(myShader);


    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        isOn_depth = toggle_depth.GetComponent<Toggle>().isOn;
        isOn_invert = toggle_invert.GetComponent<Toggle>().isOn;

        if (isOn_invert)
        {
            Graphics.Blit(source, destination, myMaterial, 0);
        }
        else if (isOn_depth)
        {
            Graphics.Blit(source, destination, myMaterial, 1);
        }
        else
        {
            Graphics.Blit(source, destination);
        }



    }


}
