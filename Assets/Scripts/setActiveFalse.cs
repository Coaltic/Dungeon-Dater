using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveFalse : MonoBehaviour
{
    public GameObject dialoguePrompt;

    void Start()
    {
        dialoguePrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
