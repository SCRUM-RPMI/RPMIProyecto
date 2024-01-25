using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchScript : MonoBehaviour
{
    public Texture[] frames;
    public float framesPerSecond = 10.0f;

    void Update()
    {
        int index = (int)(Time.time * framesPerSecond) % frames.Length;
        GetComponent<Renderer>().material.mainTexture = frames[index];
    }
}