using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateLevelLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public float LeftRotationAmount;
    public bool isPressed = false;
    public bool canRotate = false;

    public GameObject CubeBase;

    // Update is called once per frame
    void Update()
    {
        RotationCheck();
        RotateLeft();

    }

    private void RotationCheck()
    {
        if (isPressed == true)
        {
            canRotate = true;
        }

        else if (isPressed == false)
        {
            canRotate = false;
            CubeBase.transform.Rotate(0.0f, 0.0f, 0.0f);
        }

    }


    public void RotateLeft()
    {
        if (canRotate == true)
        {
            CubeBase.transform.Rotate(0.0f, 0.0f, LeftRotationAmount);
        }
    }

    public void OnPointerUp(PointerEventData eventdata)
    { 
        isPressed = false;
    }

    public void OnPointerDown(PointerEventData eventdata)
    {
        isPressed = true;
    }
}
