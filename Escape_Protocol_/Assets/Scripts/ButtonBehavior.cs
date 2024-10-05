using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

    public GameObject buttonUp;
    public GameObject buttonDown;
    public GameObject door;

    private bool weightedDown = false;

    // Sound
    AudioManager audioManager;

    // Sound Initializing
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       door.SetActive(!weightedDown);
    }

    

    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            buttonDown.SetActive(true);
            buttonUp.SetActive(false);

            // This will be used for doors later
            weightedDown = true;
        }
        else
        {
            buttonDown.SetActive(false);
            buttonUp.SetActive(true);

            weightedDown = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            audioManager.PlaySFX(audioManager.buttonPush, 10.0f);
        }
    }

    private void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box") && weightedDown == true)
        {
            buttonDown.SetActive(false);
            buttonUp.SetActive(true);

            // This will be used for doors later
            weightedDown = false;
        }
     else
        {
            buttonDown.SetActive(false);
            buttonUp.SetActive(true);

            weightedDown = false;
        }
    }
}
