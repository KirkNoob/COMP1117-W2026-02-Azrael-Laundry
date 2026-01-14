using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private int damageToDeal = 15;
        public void OnAttack(InputValue value)
    {
        if(value.isPressed)
        {
            if (playerController != null)
            {
                playerController.TakeDamage(15);
            }
          
            Debug.Log("Attacking the player");
        }
    }
}
