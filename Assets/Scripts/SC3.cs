using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC3 : MonoBehaviour
{
    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && !hasCollided)
        {
            hasCollided = true;
            StartCoroutine(LoadSceneAfterDelay(3f));
        }
    }

    private System.Collections.IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(3);
    }
}
