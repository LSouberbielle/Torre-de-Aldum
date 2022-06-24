using System.Collections.Generic;
using UnityEngine;

public class NPCsBehaviours : MonoBehaviour
{
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float rotateSpeed;
    [SerializeField] protected Transform playerTransform;
    [SerializeField] protected float stopDistance;
    [SerializeField] public List<Transform> Waypoints;
    [SerializeField] private float minimunDistanceToWaypoint = 1;
    [SerializeField] protected Transform rayCastingNose;
    [SerializeField] private float raycastRange = 10;
    [SerializeField] private LayerMask objectToCollideWith;
    private int _index = 0;
    private int _waypointAmount;

    
    protected void FollowSeenPlayer()
    {
        var hasSeenPlayer = Physics.Raycast(rayCastingNose.position, rayCastingNose.forward, raycastRange, objectToCollideWith);
        
        if (hasSeenPlayer)
        {
            FollowPlayer();   
        }
    }
    
    private void FollowPlayer()
    {
        var playerRefDistance = playerTransform.position - transform.position;
        var distanceToPlayer = playerRefDistance.magnitude;
        var dirToPlayer = playerRefDistance.normalized;
        Move(dirToPlayer, distanceToPlayer, playerRefDistance);
    }

    private void Move(Vector3 dir, float distanceToPlayer, Vector3 playerRefDistance)
    {
        var newRotation = Quaternion.LookRotation(playerRefDistance);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * rotateSpeed);
        if (distanceToPlayer > stopDistance)
            transform.position += dir * (Time.deltaTime * moveSpeed);
    }
    
    protected void Patrol()
    {
        var transform1 = transform;
        var position = transform1.position;
        var initialDistance = Waypoints[_index].position - position;

        var dir = initialDistance.normalized;

        position += moveSpeed * Time.deltaTime * dir;
        transform1.position = position;

        var distanceToWaypoint = initialDistance.magnitude;
        transform.LookAt(dir);
        if (distanceToWaypoint < minimunDistanceToWaypoint)
        {
            CheckNextWaypoint();
        }
    }
    private void CheckNextWaypoint()
    {
        _index++;
        if (_index == Waypoints.Count)
        {
            _index = 0;
        }
    }
}
