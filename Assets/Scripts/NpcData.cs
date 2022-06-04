using UnityEngine;

[CreateAssetMenu (menuName = "ScriptableObjects/NPCs/NpcData", fileName = "NewNpcData", order = 0)]
public class NpcData : ScriptableObject
{
    public Transform rayCastingNose;
    public float raycastRange = 10;
    public float stopDistance;
    public LayerMask objectToCollideWith;
    public float moveSpeed;
    public float rotateSpeed;
}
