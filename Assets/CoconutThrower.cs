using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutThrower : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip throwSound;
    public float throwSpeed = 30.0f;
    public static bool canThrow = false;
    public Rigidbody coconutPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canThrow)
        {
            GetComponent<AudioSource>().PlayOneShot(throwSound);
    Rigidbody newCoconut = Instantiate(coconutPrefab, transform.position, transform.rotation) as Rigidbody;
            newCoconut.velocity = transform.forward * throwSpeed;
            newCoconut.name = "coconut";
        }
    }
}
