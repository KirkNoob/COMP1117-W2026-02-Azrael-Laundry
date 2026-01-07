using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
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
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
   void FixedUpdate()
    {
        ApplyMovement();
    }
    void ApplyMovement()
    {
        float velocityX = moveInput.x;
        rBody.linearVelocity = new Vector2(velocityX, rBody.linearVelocity.y);
    }
}
