using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateLevelRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    // --------------------------------->
    // SET VARIABLES
    // --------------------------------->

    public float RightRotationAmount;
    public float RightRotationAmount_Label;
    public float RightRotationAmountY_Label;
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
        RotateRight();

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

    // ---------------------------------->



    // ---------------------------------->
    // ADDITIONAL FUNCTIONS
    // ---------------------------------->

    public void RotateRight()
    {
        if (canRotate == true)
        {
            Overworld_Cube.transform.Rotate(0.0f, 0.0f, RightRotationAmount);
            BoardMarkerLabel_TranquilTree.transform.Rotate(0.0f, RightRotationAmountY_Label, RightRotationAmount_Label);
            BoardMarkerLabel_MushroomMeadows.transform.Rotate(0.0f, RightRotationAmountY_Label, RightRotationAmount_Label);
            
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

    // --------------------------------->



    
}
