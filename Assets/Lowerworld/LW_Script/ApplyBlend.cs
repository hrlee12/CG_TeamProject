using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyBlend : MonoBehaviour
{
    Shader BlendSha;
    Material BlendMat;

    public Texture2D BlendTexture;
    public float blendOpacity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        BlendSha = Shader.Find("Custom/LowerWorld/ImageEffect/EffectBlend");
        BlendMat = new Material(BlendSha);
    }

    // Update is called once per frame
    void Update()
    {
        blendOpacity = Mathf.Clamp(blendOpacity, 0.0f, 1.0f);
    }

    private void OnDisable()
    {
        if (BlendMat)
        {
            DestroyImmediate(BlendMat);
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        BlendMat.SetTexture("_BlendTex", BlendTexture);
        BlendMat.SetFloat("_Opacity", blendOpacity);
        Graphics.Blit(source, destination, BlendMat);
    }
}
