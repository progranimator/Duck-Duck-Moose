using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateLevelLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // --------------------------------->
    // SET VARIABLES
    // --------------------------------->
    
    public float LeftRotationAmount;
    public float LeftRotationAmount_Label;
    public float LeftRotationAmountY_Label;
    public bool isPressed = false;
    public bool canRotate = false;

    public GameObject Overworld_Cube;
    public GameObject BoardMarkerLabel_TranquilTree;
    public GameObject BoardMarkerLabel_MushroomMeadows;

    // --------------------------------->



    // --------------------------------->
    // BUILT-IN FUNCTIONS
    // --------------------------------->

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
            Overworld_Cube.transform.Rotate(0.0f, 0.0f, 0.0f);
            BoardMarkerLabel_TranquilTree.transform.Rotate(0.0f, 0.0f, 0.0f);
            BoardMarkerLabel_MushroomMeadows.transform.Rotate(0.0f, 0.0f, 0.0f);
        }

    }

    // --------------------------------->



    // ---------------------------------->
    // ADDITIONAL FUNCTIONS
    // ---------------------------------->

    public void RotateLeft()
    {
        if (canRotate == true)
        {
            Overworld_Cube.transform.Rotate(0.0f, 0.0f, LeftRotationAmount);
            BoardMarkerLabel_TranquilTree.transform.Rotate(0.0f, LeftRotationAmountY_Label, LeftRotationAmount_Label);
            BoardMarkerLabel_MushroomMeadows.transform.Rotate(0.0f, LeftRotationAmountY_Label, LeftRotationAmount_Label);
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

    // ------------------------------------------>




}
