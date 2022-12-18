using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial;


    public GameObject slide_brightness;
    public GameObject slide_saturation;
    public GameObject slide_contrast;


    float value_brightness;
    float value_saturation;
    float value_contrast;


    // Start is called before the first frame update
    void Start()
    {

        slide_brightness.GetComponent<Slider>().value = 0.33f;
        slide_saturation.GetComponent<Slider>().value = 0.33f;
        slide_contrast.GetComponent<Slider>().value = 0.33f;


        myShader = Shader.Find("My/color");
        myMaterial = new Material(myShader);


    }

    // Update is called once per frame
    void Update()
    {

        value_brightness = slide_brightness.GetComponent<Slider>().value * 3;
        value_saturation = slide_saturation.GetComponent<Slider>().value * 3;
        value_contrast = slide_contrast.GetComponent<Slider>().value * 3;

        value_brightness = Mathf.Clamp(value_brightness, 0.0f, 3.0f);
        value_saturation = Mathf.Clamp(value_saturation, 0.0f, 3.0f);
        value_contrast = Mathf.Clamp(value_contrast, 0.0f, 3.0f);


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



        myMaterial.SetFloat("_Brightness", value_brightness);
        myMaterial.SetFloat("_Saturation", value_saturation);
        myMaterial.SetFloat("_Contrast", value_contrast);
        Graphics.Blit(source, destination, myMaterial);
    }
}