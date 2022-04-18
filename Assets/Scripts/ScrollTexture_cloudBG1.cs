using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture_cloudBG1 : MonoBehaviour
{

    Renderer rend;

    public Skybox box;
    public float scrollSpeed_MainTex;
    public float offsetTexture_MainTex;
    public float _RotationSpeed;
     

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime);
        Debug.Log("Set");
        
    }
}
