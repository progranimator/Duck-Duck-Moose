using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boardMarker4 : MonoBehaviour
{

    // --------------------------------->
    // set variables
    // --------------------------------->

    public GameObject DuckModelReference;
    public GameObject boardMarker_top;
    public GameObject reference_boardMarker4;

    public Vector3 duckPosition;

    private MeshRenderer boardMarkerColor;

    public bool CanSetVisibility = false;
    public bool isPressed = false;
    public bool isReleased = false;
    public bool isVisible = true;
    public bool isHidden = false;

    // --------------------------------->
    // --------------------------------->
    // --------------------------------->


    void Start()
    {
        boardMarkerColor = GetComponent<MeshRenderer>();

    }

    //  check if player can set visibility of boardMarker
    void Update()
    {
        VisibilityCheck();
    }

    private void VisibilityCheck()
    {
        if (isPressed == true)
        {
            boardMarkerColor.material.color = Color.red;
            DuckModelReference.transform.position = reference_boardMarker4.transform.position;
        }

        else if (isPressed == false)
        {
            CanSetVisibility = false;
            GetComponent<Renderer>().enabled = true;
        }

    }

    public void SetVisibility()
    {
        if (CanSetVisibility == true)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }

    public void OnMouseUp()
    {
        isPressed = false;
    }

    public void OnMouseDown()
    {
        isPressed = true;
    }


}
