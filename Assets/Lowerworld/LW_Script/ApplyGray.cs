using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyGray : MonoBehaviour
{
    Shader GraySha;
    Material GrayMat;

    public float grayScaleAmount = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        GraySha = Shader.Find("Custom/LowerWorld/ImageEffect/EffectGray");
        GrayMat = new Material(GraySha);
    }

    // Update is called once per frame
    void Update()
    {
        grayScaleAmount = Mathf.Clamp(grayScaleAmount, 0.0f, 1.0f);
    }

    private void OnDisable()
    {
        if (GrayMat)
        {
            DestroyImmediate(GrayMat);
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        GrayMat.SetFloat("_GrayScaleAmount", grayScaleAmount);
        Graphics.Blit(source, destination, GrayMat);
    }
}
