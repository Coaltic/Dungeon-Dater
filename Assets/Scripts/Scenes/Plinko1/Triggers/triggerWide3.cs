using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWide3 : MonoBehaviour
{
    public GameObject wideCamera4;
    public GameObject wideCamera5;


    public void OnTriggerEnter(Collider other)
    {
        wideCamera4.SetActive(false);
        wideCamera5.SetActive(true);

    }


}