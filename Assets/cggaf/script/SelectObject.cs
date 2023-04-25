using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectObject : MonoBehaviour
{
    private XRBaseInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRBaseInteractable>();
        interactable.onSelectEntered.AddListener(OnSelectEnter);
    }

    private void OnSelectEnter(XRBaseInteractor interactor)
    {
        PlaySoundOnSelect playSound = GetComponent<PlaySoundOnSelect>();
        if (playSound != null)
        {
            playSound.PlaySound();
        }
    }
}
