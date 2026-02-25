using UnityEngine;
using UnityEngine.InputSystem;

namespace Apps.Scripts
{
   public class AttackAction : MonoBehaviour
{
   public InputActionReference Attack;
   public Animator animator;

   private void onEnable()
        {
            Attack.action.performed += OnAttack;
        }

        private void OnDisable ()
        {
            Attack.action.performed -= OnAttack;
        }

        private void OnAttack(InputAction.CallbackContext context)
        {
            Execute(true);
        }

        public void Execute(bool isAttackng)
        {
            if (isAttackng)
            {
                Debug.Log("Attack triggered");

                if(animator != null)
                {
                    animator.SetTrigger("Attack");
                }
            }
        }   
}
}