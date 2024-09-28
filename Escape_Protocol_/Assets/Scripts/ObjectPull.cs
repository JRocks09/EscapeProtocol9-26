using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPull : MonoBehaviour
{
	public float defaultMass;
	public float imovableMass;
	public bool beingPushed;
	float xPos;

	public Vector3 lastPos;
	
	public int mode;
	public int colliding;

	Rigidbody2D rb;
	
	// Use this for initialization
	void Start ()
	{
		xPos = transform.position.x;
		lastPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
		beingPushed = false;
    }
	
	// Update is called once per frame
	void FixedUpdate ()	
	{
		if (mode == 0)
		{
			if (beingPushed == false)
			{
				transform.position = new Vector3(xPos, transform.position.y);
				rb.constraints = 
					RigidbodyConstraints2D.FreezePositionX |
					RigidbodyConstraints2D.FreezeRotation;
			}
			else
			{
				xPos = transform.position.x;
				rb.constraints = RigidbodyConstraints2D.None;
            }
		}

		/*else if (mode == 1)
		{
			if (beingPushed == false)
			{
				rb.mass = imovableMass;
			}
			else
			{
				rb.mass = defaultMass;
				//	GetComponent<Rigidbody2D> ().isKinematic = false;
			}
		}*/
	}

}