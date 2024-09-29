using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPushPull : MonoBehaviour
{

	public float distance = 0.5f;
	public LayerMask boxMask;

	GameObject HeavyObject;

	// Sound
	AudioManager audioManager;

	// Sound Initializing
	private void Awake()
	{
		audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
	}

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		Physics2D.queriesStartInColliders = false;
		RaycastHit2D hit= Physics2D.Raycast (transform.position, Vector2.right * transform.localScale.x, distance, boxMask);
	
		if (hit.collider != null && hit.collider.gameObject.tag == "Box" && Input.GetKeyDown (KeyCode.P)) 
		{
			HeavyObject = hit.collider.gameObject;
			HeavyObject.GetComponent<FixedJoint2D> ().connectedBody = GetComponent<Rigidbody2D> ();
			HeavyObject.GetComponent<FixedJoint2D> ().enabled = true;
			HeavyObject.GetComponent<ObjectPull> ().beingPushed = true;
			// Plays Box Push sound
			audioManager.PlaySFX(audioManager.boxPush, 3.0f);
		} 
		else if (Input.GetKeyUp (KeyCode.P)) 
		{
			HeavyObject.GetComponent<FixedJoint2D> ().enabled = false;
			HeavyObject.GetComponent<ObjectPull> ().beingPushed = false;
		}

    }


void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawLine (transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
	}
}