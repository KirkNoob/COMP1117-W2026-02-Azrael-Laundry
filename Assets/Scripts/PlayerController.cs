using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("initial player stats")]
    //initial player stats
    [SerializeField]private float initialSpeed = 10;
    [SerializeField] private int initialHealth = 100;
    private PlayerStats stats;
    
    //components
    private Rigidbody2D rBody;
    //Field Variables
    private Vector2 moveInput;
  void Awake()
    {
        //Initialize
        rBody = GetComponent<Rigidbody2D>();
        stats = new PlayerStats();
        stats.MoveSpeed = initialSpeed;
        stats.MaxHealth = initialHealth;
        stats.CurrentHealth = initialHealth;
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
   void FixedUpdate()
    {
        ApplyMovement();
    }
    private void ApplyMovement()
    {
        float velocityX = moveInput.x * stats.MoveSpeed;
        rBody.linearVelocity = new Vector2(velocityX, rBody.linearVelocity.y);
    }
    public void TakeDamage(int damageAmount)
    {
        stats.CurrentHealth -= damageAmount;
        Debug.Log("Player took damage");
    }
}
