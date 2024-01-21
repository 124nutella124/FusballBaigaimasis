using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Transform target;
    public float Force;
    public Slider forceUI;
    private bool isPoweringUp;
    public AudioSource AudioPlayer;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!isPoweringUp)
            {
                StartCoroutine(PowerUpForce());
                isPoweringUp = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopPoweringUp();
            Shoot();
            StartCoroutine(Wait());
        }
    }

    private IEnumerator PowerUpForce()
    {
        while (true)
        {
            Force += 1f;
            Slider();
            yield return new WaitForSeconds(0.015f);
        }
    }

    private void StopPoweringUp()
    {
        StopAllCoroutines();
        isPoweringUp = false;
    }

    public void Shoot()
    {
        Vector3 shoot = (target.position - transform.position).normalized;
        GetComponent<Rigidbody>().AddForce(shoot * Force, ForceMode.Impulse);
    }

    public void Slider()
    {
        forceUI.value = Force;
    }

    public void Reset()
    {
        Force = 0f;
        forceUI.value = 0f;
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
        Reset();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            AudioPlayer.Play();
        }
    }
}
