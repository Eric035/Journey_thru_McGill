using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostProcess : MonoBehaviour
{
    public Renderer rend;
    //public Material material;
    public float radius = 2.0f;


    void Start() {

        rend = GetComponent<Renderer>();
    }

    private void Update()
    { 
        rend.material.SetFloat("_radius_of_vignette", radius);
    }
    
    /*void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material, 0);
    }*/
}

