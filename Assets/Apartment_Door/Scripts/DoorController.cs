using UnityEngine;

public class DoorController : MonoBehaviour
{

    private bool doorOpened;                    //Check if door is currently opened or not

    private Animation doorAnim;

    enum DoorState
    {
        Closed,
        Opened,
    }

    DoorState doorState = new DoorState();      //To check the current state of the door

    /// <summary>
    /// Initial State of every variables
    /// </summary>
    private void Start()
    {
        doorOpened = false;                     //Is the door currently opened                
        doorState = DoorState.Closed;           //Starting state is door closed


        doorAnim = transform.parent.gameObject.GetComponent<Animation>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            doorOpened = !doorOpened;           //The toggle function of door to open/close

           
            if (doorState == DoorState.Opened)
            {
                doorAnim.Play("Door_Close");
                doorState = DoorState.Closed;
            }

            else if (doorState == DoorState.Closed)
            {
                doorAnim.Play("Door_Open");
                doorState = DoorState.Opened;
            }
        }
    }
}
