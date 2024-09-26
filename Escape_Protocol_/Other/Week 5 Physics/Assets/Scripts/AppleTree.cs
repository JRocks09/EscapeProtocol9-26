using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Prefab for instantiating apples
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float directionChangeChance = 0.1f;
    public float secondsBetweenDrops = 1f;

    void Start()
    {

    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = pos.x + speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }

        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }

        else if (Random.value < directionChangeChance)
        {
            speed = speed * -1;
        }
    }
}
