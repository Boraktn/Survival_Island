using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powercell : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 100.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "person")
        {
            other.gameObject.SendMessage("CellPickup");
            Destroy(gameObject);
        }
    }
}
