using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

public GameObject buttonUp;
public GameObject buttonDown;

private bool WeightedDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            buttonDown.SetActive(true);
            buttonUp.SetActive(false);

            // This will be used for doors later
            WeightedDown = true;
        }
    }

    private void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box") && WeightedDown == true)
        {
            buttonDown.SetActive(false);
            buttonUp.SetActive(true);

            // This will be used for doors later
            WeightedDown = false;
        }
    }

}
