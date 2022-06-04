using UnityEngine;
public class InmatesManager : NPCsBehaviours
{
    [SerializeField] private NpcData data;
    private void Update()
    {
        FollowSeenPlayer(); //Por algún motivo no respeta la Stop Distance
    } 
}