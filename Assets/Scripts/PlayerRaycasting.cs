
using System;
using UnityEngine;

public class PlayerRaycasting : MonoBehaviour
{

    [SerializeField] private float raycastRange = 10;
    [SerializeField] private GameObject nameTag;

    private void Update()
    {
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.forward);

        if (Physics.Raycast(landingRay, out hit, raycastRange))
        {
            if (hit.collider.tag == "Inmates")
            {
                nameTag.SetActive(true);
            }
        }
    }

    /* protected void FollowSeenPlayer()
    {
        var hasSeenPlayer = Physics.Raycast(rayCastingNose.position, rayCastingNose.forward, raycastRange, objectToCollideWith);
        
        if (hasSeenPlayer)
        {
        }
    } */
}
