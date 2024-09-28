using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

public GameObject StartOn;
public GameObject StartOff;

private bool WeightedDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionStay2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Box"))
        {
            StartOn.SetActive(true);
            StartOff.SetActive(false);

            WeightedDown = true;
        }
        else
        {
            StartOn.SetActive(false);
            StartOff.SetActive(true);

            WeightedDown = false;
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Box") && WeightedDown == true)
        {
            StartOn.SetActive(false);
            StartOff.SetActive(true);

            WeightedDown = false;
        }
        else
        {
            StartOn.SetActive(false);
            StartOff.SetActive(true);

            WeightedDown = false;
        }
    }

}
