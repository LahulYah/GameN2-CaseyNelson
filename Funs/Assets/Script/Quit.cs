using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{

    public Button quit;

    void Update()
    {
        quit.GetComponent<Button>().onClick.AddListener(Quitt);
    }
    public void Quitt()
    {
        Debug.Log("Yop");
        Application.Quit();

    }
}
