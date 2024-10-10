using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Platform Movement Speed
    public Transform posA, posB;
    public int Speed;
    Vector2 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = posB.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < .1f) targetPos = posB.position;

        if (Vector2.Distance(transform.position, posB.position) < .1f) targetPos = posA.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
    }
}
