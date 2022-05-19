using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddd : MonoBehaviour
{
    /*private bool doorIsOpen = false;
    public float doorTime = 0.0f;
    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
    public AudioClip audioClip;*/
    public GameObject currentDoor;  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*void onControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "playerdoor" && doorIsOpen == false)
        {
            OpenDoor(hit.gameObject);
        }

    }
    void OpenDoor(GameObject door)
    {
        doorIsOpen = true;
        door.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
    }
    // Update is called once per frame*/
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward,out hit, 3))
        {
             
            if (hit.collider.gameObject.tag == "playerdoor")
            {
                currentDoor = hit.collider.gameObject;
                currentDoor.SendMessage("DoorCheck");
            }
        }
    }
    
}
