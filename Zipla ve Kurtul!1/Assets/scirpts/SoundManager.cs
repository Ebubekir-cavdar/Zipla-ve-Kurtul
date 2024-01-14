using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip Die;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Died()
    {
	audioSource.PlayOneShot(Die);
     }
}
