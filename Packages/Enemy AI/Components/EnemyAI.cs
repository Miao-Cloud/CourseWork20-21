using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent; //This is a navmesh. It needs to be added to the objecto yes.
    public Transform player; //Transformo evolution pokemon. yes.
    public LayerMask whatIsGround, whatIsPlayer; //WHERE IS THE FLOOR

    public Vector3 walkPoint; //Walking
    bool walkPointSet; //more walking 
    public float walkPointRange; //even.. more.. =_= hmm...

    public float sightRange,; //I see u
    public bool playerInSightRange; //ohoh i DO see u

    private void Awake() //WAKE UP
    {
        player = GameObject.Find("PlayerObj").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer); //can I see u?

        if (!playerInSightRange) Patroling(); //Not yet..
        if (playerInSightRange) ChasePlayer(); //RUN BOI RUNNNNN
    }

    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint(); //S.C.A.N.N.I.N.G
        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false; //sad robo noises
    }
    private void SearchWalkPoint() //IM LOOKING BRUH
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }

    private void ChasePlayer() //O HAI THERE
    {
        agent.SetDestination(player.position);
    }

    private void OnDrawGizmosSelected() //noice red gizmoso mitosis. yes.
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, sightRange); 
    }
