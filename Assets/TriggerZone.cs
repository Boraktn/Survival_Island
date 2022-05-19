using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
    public Light doorLight;
    public Text textHints;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("entered zone");
        if (other.gameObject.name == "FPSController")
        {
            Debug.Log("asd");
            if (Inventory.charge == 4)
            {
            transform.Find("door").SendMessage("DoorCheck");
                if (GameObject.Find("PowerGUI"))
                {
                    Destroy(GameObject.Find("PowerGUI"));
                    doorLight.color = Color.green;
                }
            }
            else if(Inventory.charge>0 && Inventory.charge < 4)
            {
                textHints.SendMessage("ShowHint", "This door won't budge.. guess it needs fully charging - maybe more cells will help...");
            }
            else
            {
                textHints.SendMessage("ShowHint", "This door seems locked.. maybe that generator needs power...");
            }

        }
    }
}
