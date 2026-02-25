using UnityEngine;
using UnityEngine.InputSystem;

namespace Apps.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        private MovementAction _movementAction;
        private AttackAction _attackAction;
        
        private void Awake()
        {
            _movementAction = GetComponent<MovementAction>();
            _attackAction = GetComponent<AttackAction>();
        }

        // WAJIB PUBLIC dan parameter CallbackContext
        public void OnMove(InputAction.CallbackContext ctx)
        {
            if (_movementAction == null)
            {
                Debug.LogWarning("MovementAction missing", this);
                return;
            }

            if (ctx.performed || ctx.canceled)
            {
                _movementAction.Execute(ctx.ReadValue<Vector2>());
            }
        }
    }
}