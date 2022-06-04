using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;

    private void Update()
    {
        MovementInputs();
    }

    private void MovementInputs()
    {
        var inputX = Input.GetAxis("Horizontal");
        var inputY = Input.GetAxis("Vertical");

        Move(inputY);
        Rotate(inputX);
    }

    private void Move(float input)
    {
        var transform1 = transform;
        transform1.position += transform1.forward * (moveSpeed * input * Time.deltaTime);
    }

    private void Rotate(float input)
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * input * rotateSpeed), Space.Self);
    }
}