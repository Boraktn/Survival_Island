using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThrowTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textHints;
    void Start()
    {
        RawImage im = GameObject.Find("CrossHair").GetComponent<RawImage>();
        if (im)
            im.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "person")
        {
            CoconutThrower.canThrow = true;
            RawImage im = GameObject.Find("Crosshair").GetComponent<RawImage>();
            if (im)
            {
                im.enabled = true;
            }
            if (!CoconutWin.haveWon)
            {
                textHints.SendMessage("ShowHint", "There is a power cell attached to this game," + " you may win it if you knock down all targets");
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "person")
        {
            CoconutThrower.canThrow = false;
        }
    }
}
