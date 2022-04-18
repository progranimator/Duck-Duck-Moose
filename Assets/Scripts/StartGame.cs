using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool isPressed = false;
    public bool canRotate = false;


    void Update()
    {
        StartGameCheck();
    }


    private void StartGameCheck()
    {
        if (isPressed == true)
        {
            Menu_StartGame();
        }
    }


    private void Menu_StartGame()
    {
        {
            SceneManager.LoadSceneAsync(1);
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
