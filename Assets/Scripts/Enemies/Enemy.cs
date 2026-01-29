using UnityEngine;

public class Enemy : Character
{
    [Header("Enemy Settings")]
    [SerializeField] private float patrolDistance = 5.0f;

    private Vector2 startPos;
    private int direction = -1 
    protected override void Awake()
    {
        base.Awake();
        startPos = transform.position;
        Debug.Log("Awake in Enemy.cs");
    }
    private void Update()
    {
        float leftBoundary = startPos.x - patrolDistance;
        float rightBoundary = startPos.x + patrolDistance;
        transform.Translate(Vector2.right * direction * MoveSpeed * Time.deltaTime);
        if(transform.position.x >= rightBoundary)
        {
            direction = -1;
            tranform.localScale = new Vector3(1, 1, 1);
        }
        else if (transform.position.x <= leftBoundary)
        {
            direction = 1;
            transform.localScale = new Vector3(-1, 1, 1);

        }
    }
}
