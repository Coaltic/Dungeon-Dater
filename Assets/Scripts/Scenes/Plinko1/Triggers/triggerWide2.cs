using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWide2 : MonoBehaviour
{
    public GameObject wideCamera2;
    public GameObject wideCamera3;


    public void OnTriggerEnter(Collider other)
    {
        wideCamera2.SetActive(false);
        wideCamera3.SetActive(true);

    }


}