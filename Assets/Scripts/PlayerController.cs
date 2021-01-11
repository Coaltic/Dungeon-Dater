using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject gameoverTextObject;
    public GameObject dialoguePrompt;
    public AudioSource collectCoin;
    public AudioSource deathAudio;
    public AudioSource restart;
    

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
        gameoverTextObject.SetActive(false);
        dialoguePrompt.SetActive(false);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Coins: " + count.ToString();
        if (count >= 65)
        {
            winTextObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);


    }

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            restart.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
    if (other.gameObject.CompareTag("PickUp"))
    {
        collectCoin.Play();
        other.gameObject.SetActive(false);
        count = count + 1;

        SetCountText();
    }

    if (other.gameObject.CompareTag("Plate"))
        {
            deathAudio.Play();
            gameObject.SetActive(false);
            gameoverTextObject.SetActive(true);

        }

    }
}
