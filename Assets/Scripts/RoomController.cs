using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RoomController : MonoBehaviour
{
    [Header("Public References")]

    [Tooltip("Add all rooms to this array")]
    public Room[] rooms; // later on this will hopefully be a dynamic binary tree instead of a static array


    private int currentRoom = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void goRight()
    {
        int newRoom = 1; //here we will check from that binary tree which room we are supposed to go to and store in newRoom var

        rooms[currentRoom].gameObject.SetActive(false);
        //deactivate old room
        currentRoom = newRoom;
        //activate the new room
        rooms[currentRoom].gameObject.SetActive(true);


        UIController.ui.updateStatus(rooms[currentRoom].roomName);//update the ui to reflect new room
        UIController.ui.hideMovement();
    }
    public void goLeft()
    {
        int newRoom = 2; //here we will check from that binary tree which room we are supposed to go to and store in newRoom var
     
        rooms[currentRoom].gameObject.SetActive(false);
        //deactivate old room
        currentRoom = newRoom;
        //activate the new room
        rooms[currentRoom].gameObject.SetActive(true);


        UIController.ui.updateStatus(rooms[currentRoom].roomName);
        UIController.ui.hideMovement();
    }
    public void goForward()
    {
        int newRoom = 3; //here we will check from that binary tree which room we are supposed to go to and store in newRoom var

        rooms[currentRoom].gameObject.SetActive(false);
        //deactivate old room
        currentRoom = newRoom;
        //activate the new room
        rooms[currentRoom].gameObject.SetActive(true);


        UIController.ui.updateStatus(rooms[currentRoom].roomName);
        UIController.ui.hideMovement();
    }
    public void goBack()
    {
        int newRoom = 0; //here we will check from that binary tree which room we are supposed to go to and store in newRoom var

        rooms[currentRoom].gameObject.SetActive(false);
        //deactivate old room
        currentRoom = newRoom;
        //activate the new room
        rooms[currentRoom].gameObject.SetActive(true);


        UIController.ui.updateStatus(rooms[currentRoom].roomName);
        UIController.ui.showMovement();
    }
}
