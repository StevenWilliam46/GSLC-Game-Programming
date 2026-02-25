using UnityEngine;

namespace Apps.Scripts
{
    public class MovementAction : MonoBehaviour, ICharacterAction<Vector2>
    {
        [SerializeField, Range(0, 30)] private float movementSpeed = 5f;
        
        private Rigidbody _rb;
        private Vector3 _direction;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            if (_rb == null)
                Debug.LogWarning("No Rigidbody attached to the object", this);
        }

        private void FixedUpdate()
        {
            // Debug velocity
            Debug.Log("Velocity sekarang: " + _rb.linearVelocity);

            _direction.y = _rb.linearVelocity.y;
            _rb.linearVelocity = _direction;
        }

        public void Execute(Vector2 info)
        {
            Debug.Log("INPUT MASUK: " + info);

            _direction.x = info.x * movementSpeed;
            _direction.z = info.y * movementSpeed;
        }
    }
}