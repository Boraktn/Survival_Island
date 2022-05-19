using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    private bool doorIsOpen = false;
    public float doorTime = 0.0f;
    public float doorOpenTime = 10.0f;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        doorTime = 0.0f;   
    }
    
    // Update is called once per frame
    void Update()
    {
        if (doorIsOpen)
        {
            doorTime += Time.deltaTime;
            if(doorTime > doorOpenTime)
            {
                Door(doorShutSound, false, "door shut");
                doorTime = 0.0f;
            } 
        }
    }
    void DoorCheck()
    {
        if (!doorIsOpen) { 
            Door(doorOpenSound, true, "door open"); 
        }

    }
    void Door(AudioClip aClip, bool openCheck, string animName)
    {
        GetComponent<AudioSource>().PlayOneShot(aClip);
        doorIsOpen = openCheck;
        transform.parent.GetComponent<Animation>().Play(animName);
    }
    /*private void OnTriggerEnter(Collider col)
    {
        Debug.Log("entered zone");
        if (col.gameObject.name == "FPSController")
        {
            transform.Find("door").SendMessage("DoorCheck");
        }
    }*/

}
