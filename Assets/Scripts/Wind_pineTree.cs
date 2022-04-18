using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind_PineTree : MonoBehaviour
{
    //WORKS WITH ALL THE NATURE/TREE CREATOR SHADERS

    private MaterialPropertyBlock materialPropertyBlock;
    private Renderer render;
   
    [SerializeField] private Vector4 wind;
   

    void Start()
    {
        materialPropertyBlock = new MaterialPropertyBlock();
    }

    void Awake()
    {
        if (!render) render = GetComponent<Renderer>();
    }

    void Update()
    {
        render.GetPropertyBlock(materialPropertyBlock);
        materialPropertyBlock.SetVector("_Wind", wind);
        render.SetPropertyBlock(materialPropertyBlock);
    }
}
