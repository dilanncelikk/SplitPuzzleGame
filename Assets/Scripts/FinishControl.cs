using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishControl : MonoBehaviour
{
    public GameObject[] SectionContol;
    public GameObject RestartPanel;
    private AudioSource audioSource;
    public AudioClip WinSound;
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ControlFinish()
    {
        for (int i = 0; i < SectionContol.Length; i++)
        {
            if ( SectionContol[i].GetComponent<SlotControl>().complete==false)
            {
                return;
            }
        }
        RestartPanel.SetActive(true);
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(WinSound);
    }
}
