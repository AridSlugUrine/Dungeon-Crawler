using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public static UIController ui;



    [Header("Public References")]

    [Tooltip("This is a placeholder to show room name etc")]
    public TMP_Text statusText;

    public Button leftButton, rightButton, forwardButton, backButton;

    private void Awake()
    {
        if (!ui)
        {
            ui = this;
        }
    }
    void Start()
    {
        showMovement();   
    }

    public void updateStatus(string roomName)
    {
        statusText .text = "Room" + roomName;    
    }

    public void hideMovement()
    {
        leftButton.gameObject.SetActive(false);
        rightButton.gameObject.SetActive(false);
        forwardButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
    }
    public void showMovement()
    {
        leftButton.gameObject.SetActive(true);
        rightButton.gameObject.SetActive(true);
        forwardButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
    }
}
