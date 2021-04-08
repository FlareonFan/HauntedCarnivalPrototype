using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField]
    bool patrolInWaiting;

    [SerializeField]
    float totalTimeToWait = 3f;

    [SerializeField]
    float switchProb = 0.2f;

    [SerializeField]
    List<Wayfinder> patrolPoints;

    UnityEngine.AI.NavMeshAgent navMeshAgent;
    int currentPatrolArea;
    bool travelling;
    bool waiting;
    bool patrolForward;
    float waitTimer;

   // private Animator anim;

    void Start()
    {
     //   anim = GetComponent<Animator>();

        navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();

        if(navMeshAgent == null)
        {
            Debug.LogError("No NavMesh");
        }
        else
        {
            if (patrolPoints != null && patrolPoints.Count >= 2)
            {
                currentPatrolArea = 0;
                SetDesination();
            }
            else
            {
                Debug.Log("Can't Patrol");
            }
        }
    }

    void Update()
    {
        if (travelling && navMeshAgent.remainingDistance <= 1.0f)
        {
            travelling = false;
            //anim.SetBool()

            if (patrolInWaiting)
            {
                waiting = true;
                waitTimer = 0f;

            }
            else
            {
                ChangePatrolPoint();
                SetDesination();
            }
        }
    }

    private void SetDesination()
    {
        if (patrolPoints != null)
        {
            Vector3 targetVector = patrolPoints[currentPatrolArea].transform.position;
            navMeshAgent.SetDestination(targetVector);
            travelling = true;
        }
    }

    private void ChangePatrolPoint()
    {
        if(UnityEngine.Random.Range(0f, 1f) <= switchProb)
        {
            patrolForward = !patrolForward;
        }

        if (patrolForward)
        {
            currentPatrolArea = (currentPatrolArea + 1) % patrolPoints.Count;
        }
        else
        {
            if(--currentPatrolArea < 0)
            {
                currentPatrolArea = patrolPoints.Count - 1;
            }
        }
    }
}
