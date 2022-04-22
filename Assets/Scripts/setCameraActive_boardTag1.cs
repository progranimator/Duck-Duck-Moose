using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCameraActive_boardTag1 : MonoBehaviour
{
    public Camera boardTagCamera1;

    // Start is called before the first frame update
    void Start()
    {
        boardTagCamera1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
