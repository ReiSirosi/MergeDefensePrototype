using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyConroller : MonoBehaviour
{
    private NavMeshAgent agent;
    private Target target;

    private Vector3 currVel;
    private Vector3 prevPos;

    public float speed;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<Target>();
        agent.destination = target.transform.position;

        StartCoroutine(CalcVelocity());
    }

    IEnumerator CalcVelocity()
    {
        while (Application.isPlaying)
        {
            // Position at frame start
            prevPos = transform.position;
            // Wait till it the end of the frame
            yield return new WaitForEndOfFrame();
            // Calculate velocity: Velocity = DeltaPosition / DeltaTime
            currVel = (transform.position - prevPos) / Time.deltaTime;
            speed = currVel.magnitude;
        }
    }
}
