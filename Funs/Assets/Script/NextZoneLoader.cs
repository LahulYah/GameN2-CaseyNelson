using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextZoneLoader : MonoBehaviour
{
    public int Zone;
    public int Zone2;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("TriggerObject"))
        {
            SceneManager.LoadScene(Zone);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(Zone2);
        }
    }
}
