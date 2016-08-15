// (C)2016 Marco Capelli
// This script is a simple rollover that can be used to detect the mouse passage over a GUI Button.
// It is possibile to change the Button image while over, as well as sounds and image size.
// Just attach this script to a GUI Button and fill the public variables in the Inspector.

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class simpleRollOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Sprite normalGUI;
    public Sprite rolloverGUI;
    public Button bttn;
    public AudioClip bttnSound;
    public AudioSource bttnHoverSound;
    public float fixedWidth;
    public float fixedHeight;
    public float newWidth;
    public float newHeight;
    public float volume = 1f;

    void Start()
    {
        bttnHoverSound.clip = bttnSound;
        bttnHoverSound.volume = volume;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse Enter");
        bttn.image.sprite = rolloverGUI;
        bttn.image.rectTransform.sizeDelta = new Vector2(newWidth, newHeight); // Use it if you want to resize the button accordingly
        bttnHoverSound.Play();

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse Exit");
        bttn.image.sprite = normalGUI;
        bttn.image.rectTransform.sizeDelta = new Vector2(fixedWidth, fixedHeight); // Use it if you want to resize the button accordingly
    }

}