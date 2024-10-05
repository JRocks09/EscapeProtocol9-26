using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

    public GameObject buttonUp;
    public GameObject buttonDown;

    private bool WeightedDown = false;

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
        
    }

    


    private void OnCollisionStay2D(UnityEngine.Collision2D other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            buttonDown.SetActive(true);
            buttonUp.SetActive(false);
            // Plays Box Push sound
            audioManager.PlaySFX(audioManager.buttonPush, 10.0f);

            // This will be used for doors later
            WeightedDown = true;
        }
        else
        {
            buttonDown.SetActive(false);
            buttonUp.SetActive(true);

            WeightedDown = false;
        }
    }

//this will hopefully make the box think its not moving off the button

    private void OnCollisionExit2D(UnityEngine.Collision2D other)
    {
        if (other.gameObject.CompareTag("Box") && WeightedDown == true)
        {
            buttonDown.SetActive(false);
            buttonUp.SetActive(true);

            // This will be used for doors later
            WeightedDown = false;
        }
     else
        {
            buttonDown.SetActive(false);
            buttonUp.SetActive(true);

            WeightedDown = false;
        }
    }
}
