
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerStart : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject wideCamera1;


    public void OnTriggerEnter(Collider other)
    {
        mainCamera.SetActive(false);
        wideCamera1.SetActive(true);

    }


}
