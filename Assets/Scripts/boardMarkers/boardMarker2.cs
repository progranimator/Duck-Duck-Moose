using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boardMarker2 : MonoBehaviour
{

    // --------------------------------->
    // SET VARIABLES
    // --------------------------------->

    public boardMarkerPopupEnter_MushroomMeadows reference_boardMarkerPopupEnter_MushroomMeadows;
    
    public Vector3 duckPosition;

    public GameObject DuckModelReference;
    public GameObject reference_boardMarker2;
    public GameObject reference_boardMarker1Label;
    public GameObject reference_boardMarker2Label;
    public GameObject reference_boardMarker3Label;
    public GameObject reference_boardMarker4Label;
    public GameObject reference_boardMarker5Label;

    private MeshRenderer boardMarkerColor;

    private bool setVisibility = false;
    private int LevelCheck;

    public bool CanSetVisibility = false;
    public bool isPressed = false;
    public bool isReleased = false;
    public bool isVisible = true;
    public bool isHidden = false;

    // --------------------------------->

    


    // --------------------------------->
    // BUILT-IN FUNCTIONS
    // --------------------------------->

    void Start() 
    { 

        boardMarkerColor = GetComponent<MeshRenderer>();

        LevelCheck = 0;
       
    }
    
    
    
    
    void Update()
    { 
        VisibilityCheck();
       // LevelVisibilityCounter();
    }

    private void VisibilityCheck()
    {
        if (isPressed == true)
        {

            boardMarkerColor.material.color = Color.red;

            reference_boardMarker1Label.SetActive(false);
            reference_boardMarker2Label.SetActive(true);
            reference_boardMarker3Label.SetActive(false);
            reference_boardMarker4Label.SetActive(false);
            reference_boardMarker5Label.SetActive(false);
            
            DuckModelReference.transform.position = reference_boardMarker2.transform.position;

            reference_boardMarkerPopupEnter_MushroomMeadows.SetVisibility();
            reference_boardMarkerPopupEnter_MushroomMeadows.resetLevelCounter();

        }

        else if (isPressed == false)
        
        {
            CanSetVisibility = false;
            GetComponent<Renderer>().enabled = true;
        }

    }

    // ---------------------------------->




    // ---------------------------------->
    // ADDITIONAL FUNCTIONS
    // ---------------------------------->
    public void OnMouseUp()
    {
        isPressed = false;
       
        LevelCheck++;
    }

    public void OnMouseDown() { isPressed = true; }
    


    
    public void SetVisibility()
    {
        if (CanSetVisibility == true)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }



    //public void LevelVisibilityCounter()
    //{
    //    if (LevelCheck == 2)
    //    {
    //        ExitLevel_MushroomMeadows.enabled = false;
    //        reference_ExitLevel_MushroomMeadows.SetActive(false);
    //        reference_ExitLevelText_MushroomMeadows.SetActive(false);
    //        reference_ExitLevelQuestionMark_MushroomMeadows.SetActive(false);
    //    }
    //}

    // ----------------------------------->
    


   
}
