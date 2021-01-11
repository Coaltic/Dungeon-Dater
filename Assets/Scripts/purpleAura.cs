using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpleAura : MonoBehaviour
{
    public GameObject dialoguePrompt;
    public GameObject dialogueBox;
    public GameObject player;
    public GameObject text1;
    public GameObject text2;
    public int x = 0;

    void Start()
    {
        dialoguePrompt.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dialoguePrompt.SetActive(false);
            dialogueBox.SetActive(true);
            text1.SetActive(true);
            text2.SetActive(false);
            player.SetActive(false);
            x = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (x == 1)
            {
                dialoguePrompt.SetActive(true);
                text2.SetActive(false);
                dialogueBox.SetActive(false);
                player.SetActive(true);
                x = x - 1;

            }

            if (x == 0)
            {
                text1.SetActive(false);
                text2.SetActive(true);
                x = x + 1;
            }

            


        }
    }

    public void OnTriggerEnter(Collider other)
    {
        dialoguePrompt.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        dialoguePrompt.SetActive(false);
    }
}
