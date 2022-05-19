using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Entered match zone");
        if (col.gameObject.name == "FPSController"){
            col.gameObject.SendMessage("MatchPickUp");
            Destroy(gameObject);
        }

    }
}
