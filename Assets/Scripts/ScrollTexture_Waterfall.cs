using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture_Waterfall : MonoBehaviour
{

    Renderer rend;
    public float scrollSpeed_MainTex;
    public float scrollSpeed_DetailAlbedoMap;
    public float offsetTexture_MainTex;
    public float offsetTexture_DetailAlbedoMap; 

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offsetTexture_MainTex = Time.time * scrollSpeed_MainTex;
        float offsetTexture_DetailAlbedoMap = Time.time * scrollSpeed_DetailAlbedoMap;

        rend.material.SetTextureOffset("_BaseMap", new Vector2(0, offsetTexture_MainTex));
        rend.material.SetTextureOffset("_DetailAlbedoMap", new Vector2(0, offsetTexture_DetailAlbedoMap));
    }
}
