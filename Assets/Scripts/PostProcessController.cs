using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessController : MonoBehaviour
{
    private PostProcessVolume _postProcessVolume;
    private Bloom _bloom;
    private void Awake()
    {
        _postProcessVolume = GetComponent<PostProcessVolume>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _postProcessVolume.profile.TryGetSettings(out Bloom _bloom))
        {
            _bloom.intensity.value += 5f;
        }
    }
}   
 
