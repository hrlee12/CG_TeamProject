using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSoundScript : MonoBehaviour
{
    AudioSource Audio;
    bool isPlay = true;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        if (isPlay)
        {
            Audio.Play();
        }
        else
        {
            Audio.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            isPlay = !isPlay;
            if (isPlay)
            {
                Audio.Play();
            }
            else
            {
                Audio.Stop();
            }
        }
    }
}
