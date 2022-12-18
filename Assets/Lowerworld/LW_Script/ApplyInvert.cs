using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyInvert : MonoBehaviour
{
    Shader InvertSha;
    Material InvertMat;

    // Start is called before the first frame update
    void Start()
    {
        InvertSha = Shader.Find("Custom/LowerWorld/ImageEffect/EffectInvertColor");
        InvertMat = new Material(InvertSha);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        if (InvertMat)
        {
            DestroyImmediate(InvertMat);
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, InvertMat, 0);
    }
}
