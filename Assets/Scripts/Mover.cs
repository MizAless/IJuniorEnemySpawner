using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Vector3 _direction;

    private void FixedUpdate()
    {
        Move();
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        transform.position += _direction * _speed * Time.fixedDeltaTime;
    }
}
