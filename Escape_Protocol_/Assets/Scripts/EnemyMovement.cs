using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform[] patrolpoints;
    public float speed;
    public int patrolDestination;

    // Update is called once per frame
    void Update()
    {
     if (patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolpoints[0].position, speed * Time.deltaTime);
            if ( Vector2.Distance(transform.position, patrolpoints[0].position) < .2f)
            {
                flip();
                patrolDestination = 1;
            }
        }

        if (patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolpoints[1].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolpoints[1].position) < .2f)
            {
                flip();
                patrolDestination = 0;
            }
        }
    }

    private void flip()
    {
        Vector3 localscale = transform.localScale;
        localscale.x *= -1;
        transform.localScale = localscale;
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }*/
}
