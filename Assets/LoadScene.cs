using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class LoadScene : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    public AudioClip beepSound;
    public Texture onRed, offGreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<AudioSource>().PlayOneShot(beepSound);
        GetComponent<RawImage>().texture = onRed;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<RawImage>().texture = offGreen;
    }
}
