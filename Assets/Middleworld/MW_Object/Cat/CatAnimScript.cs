using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimScript : MonoBehaviour
{
    Animator Anim;
    bool isPlay = true;
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 1.0f;  // 최초 애니메이션 재생 속도 1
        isPlay = true;  // 최초 isPlay = true
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isPlay = !isPlay;
            if (isPlay)
            {
                Anim.speed = 1.0f;
                print(Anim.name + " anim play");
            }
            else
            {
                Anim.speed = 0.0f;
                print(Anim.name + " anim stop");
            }
        }
    }
}
