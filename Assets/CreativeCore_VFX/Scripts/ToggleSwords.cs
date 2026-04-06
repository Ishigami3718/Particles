using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwords : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.V;
    

    public ParticleSystem particle;

    bool isPlaying = false;

    private void Start()
    {
        //particle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (!isPlaying) { particle.Play(); isPlaying = true; }
            else { particle.Stop(); isPlaying = false; }
        }
    }
}
