using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        Move();
    }

    public void SetDirection(Vector3 direction)
    {
        transform.LookAt(transform.position + direction);
    }

    private void Move()
    {
        transform.position += transform.forward * _speed * Time.fixedDeltaTime;
    }
}
