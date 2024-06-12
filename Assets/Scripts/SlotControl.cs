using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotControl : MonoBehaviour
{
    public GameObject[] SlotList;
    public GameObject correct;
    public Transform parent;
    private FinishControl finishControl;
    private AudioSource audioSource;
    public AudioClip correctSound;
    public bool complete;
    void Start()
    {
        finishControl = FindObjectOfType<FinishControl>();
        audioSource = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ControlSlot()
    {
        for (int i = 0; i < SlotList.Length; i++)
        {
            if (SlotList[i].GetComponent<ItemSlot>().check==false)
            {
                return;
            }
        }
        correct.transform.SetParent(parent);
        correct.SetActive(true);
        complete = true;
        audioSource.PlayOneShot(correctSound);
        finishControl.ControlFinish();
    }
}
