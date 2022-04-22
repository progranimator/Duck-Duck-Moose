using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setVisibility_boardTag1 : MonoBehaviour
{

    public GameObject Button_worldTag1;


    // Start is called before the first frame update
    void Start()
    {
        //boardTag1_reference = GameObject.Find ("Button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setBoardTag1_Visible()
    {
        //Button_worldTag1.SetActive(false);
        Button_worldTag1.GetComponent<Image>().enabled = false;
        Debug.Log("BoardTag1 = visible");
    }
}
