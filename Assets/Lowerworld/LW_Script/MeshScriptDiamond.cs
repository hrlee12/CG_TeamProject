using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshScriptDiamond : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5;
    Vector3[] newvert;
    int[] newtrian;
    public Texture mainTex;

    // Start is called before the first frame update
    void Start()
    {
        print("Mesh Script - Pyramid start");

        V0 = new Vector3(-0.5f, 0, -0.5f);
        V1 = new Vector3(-0.5f, 0, 0.5f);
        V2 = new Vector3(0.5f, 0, 0.5f);
        V3 = new Vector3(0.5f, 0, -0.5f);
        V4 = new Vector3(0, 1, 0);
        V5 = new Vector3(0, -1, 0);

        newvert = new Vector3[] { V0, V1, V2, V3, V4, V5 };
        newtrian = new int[] {
            0, 4, 3,
            3, 4, 2,
            2, 4, 1,
            1, 4, 0, // 여기까지 윗부분
            0, 3, 5,
            3, 2, 5,
            2, 1, 5,
            1, 0, 5
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newvert;
        mesh.triangles = newtrian;

        Shader DefSha = Shader.Find("Standard");
        Material DefMat = new Material(DefSha);

        gameObject.GetComponent<MeshRenderer>().material = DefMat;

        gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", mainTex);
        gameObject.AddComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 121) % 30 == 0)
        {
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",
                new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)));
        }
    }
}
