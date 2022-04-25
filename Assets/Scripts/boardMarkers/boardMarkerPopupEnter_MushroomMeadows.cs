using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boardMarkerPopupEnter_MushroomMeadows : MonoBehaviour
{

    // --------------------------------->
    // SET VARIABLES
    // --------------------------------->

    public GameObject DuckModelReference;
    public GameObject reference_boardMarkerPopoup_MushroomMeadows;

    private int LevelCounter;

    public bool CanSetVisibility = false;
    public bool CanChangeLevels = false;
    public bool isPressed = false;
    public bool isReleased = false;
    public bool isVisible = true;
    public bool isHidden = false;

    // --------------------------------->

    


    // --------------------------------->
    // BUILT-IN FUNCTIONS
    // --------------------------------->

    void Start() {LevelCounter = 0;}    
    void Update() 
    {
        LevelCheck();
        VisibilityCheck();
    }




    private void LevelCheck()
    {
        if (LevelCounter == 2)
        {
            Debug.Log("Switch to next level");
            SceneManager.LoadScene("MushroomMeadows");
        }

        else if (GetComponent<Renderer>() == false)
        {
            Debug.Log("Renderer is HIDDEN");
        }
    }




    private void VisibilityCheck()
    {
        if (isPressed == true)
        {
           reference_boardMarkerPopoup_MushroomMeadows.SetActive(true);
           isVisible = true;
        }

        else if (isPressed == false)
        {
            CanSetVisibility = false;
            reference_boardMarkerPopoup_MushroomMeadows.SetActive(false);
        }

    }

    // ---------------------------------->




    // ---------------------------------->
    // ADDITIONAL FUNCTIONS
    // ---------------------------------->
    
    public void OnMouseUp()
    {
        if (CanChangeLevels == false)
        {
            LevelCounter = 1;
            CanChangeLevels = true;
        }

        else if (CanChangeLevels == true)
        {
            LevelCounter = 2;
        }
    }


    public void resetLevelCounter()
    {
        LevelCounter = 0;
        CanChangeLevels = false;
    }


    public void OnMouseDown() { isPressed = true; }
    

    public void SetVisibility()
    {
        isVisible = false;
        isPressed = false;
    }

    // ----------------------------------->
    

}
