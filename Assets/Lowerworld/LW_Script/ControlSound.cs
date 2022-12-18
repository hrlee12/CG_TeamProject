using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSound : MonoBehaviour
{
    AudioSource Audio;
    bool playing;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Play();
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (playing) {
                Audio.Stop();
                playing = !playing;
            }
            else {
                Audio.Play();
                playing = !playing;
            }
        }
    }
}
