using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static int charge = 0;
    public AudioClip collectSound;
    public Texture2D[] hudCharge;
    public UnityEngine.UI.RawImage chargeHUDGUI;
    public Texture2D[] meterCharge;
    public Renderer meter;
    bool haveMatches = false;
    public Text textHints;
    // Start is called before the first frame update
    void Start()
    {   
        charge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 3))
        {
            if (hit.collider.gameObject.name == "campfire")
            {
                if (haveMatches == true) LightFire(hit.collider.gameObject);
                else textHints.SendMessage("ShowHint", "Need some matches I guess");
            }
        }
    }
    void MatchPickUp()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        haveMatches = true;
    }
    void LightFire(GameObject campFire)
    {
        ParticleSystem[] fireEmitters;
        fireEmitters = campFire.GetComponentsInChildren<ParticleSystem>();
        for(int i=0; i<fireEmitters.Length; i++)
        {
            ParticleSystem.EmissionModule em = fireEmitters[i].emission;
            em.enabled = true;
        }
        campFire.GetComponent<AudioSource>().Play();
    }
    void CellPickup()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        charge++;
        chargeHUDGUI.texture = hudCharge[charge];
        meter.material.mainTexture = meterCharge[charge];
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.name == "campfire")
        {
            //Debug.Log(haveMatches);
            if(haveMatches == true)
            {
                LightFire(hit.gameObject);
            }
            else
            {
                textHints.SendMessage("ShowHint", "Need some matches I guess");
            }
        }
    }
}
