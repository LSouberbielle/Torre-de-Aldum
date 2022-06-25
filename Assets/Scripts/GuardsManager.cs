using System;
using UnityEditor.UIElements;

public class GuardsManager : NPCsBehaviours
{
    private void Update()
    {
        Patrol(); //Me gustaría que cuando se cumplen las condiciones para el FollowSeenPlayer deje de ejecutarse el Patrol, puede ser que sea con una coroutine?
    }
    /* private void Patrol()
    {
        var transform1 = transform;
        var position = transform1.position;
        var initialDistance = guardWaypoints[_index].position - position;

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
        if (_index == guardWaypoints.Count)
        {
            _index = 0;
        }
    } */
}