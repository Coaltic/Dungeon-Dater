using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class trigger20 : MonoBehaviour
{
    public GameObject currentCamera;
    public GameObject mainCamera;
    public GameObject winText;


    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        currentCamera.SetActive(false);
        mainCamera.SetActive(true);
        winText.SetActive(true);
    }

}
