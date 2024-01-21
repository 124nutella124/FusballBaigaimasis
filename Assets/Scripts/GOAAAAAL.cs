using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAAAAAL : MonoBehaviour
{
    public GameObject canvas;
    public AudioSource AudioPlayer;

    private void Start()
    {
        canvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            canvas.SetActive(true);
            AudioPlayer.Play();
        }
    }
}
