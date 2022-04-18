using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActive_BoardMarker1 : MonoBehaviour
{
    public GameObject DuckModelReference;
    public Vector3 duckPosition;

    public bool CanSetVisibility = false;

    public bool isPressed = false;
    public bool isReleased = false;

    public bool isVisible = true;
    public bool isHidden = false;

    public GameObject boardMarker_top;
    private MeshRenderer boardMarkerColor;

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
            DuckModelReference.transform.position = duckPosition;
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
        Debug.Log("isPressed = true");
    }
}
