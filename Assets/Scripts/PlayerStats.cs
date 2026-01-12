using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerStats
{
    private int moveSpeed;
    public int MoveSpeed
    {
        get
        {
            //
            //Modify what I can return in any way I want
            //
            return moveSpeed;
        }
        }
    private int maxHealth;
    public int MaxHealth
    {
        get
        {
            //
            //Modify what I can return in any way I want
            //
            return maxHealth;
        }
    }
    private int jumpForce;
    public int JumpForce
    {
        get
        {
            //
            //Modify what I can return in any way I want
            //
            return jumpForce;
        }
    }
    public PlayerStats(int moveSpeed, int maxHealth, int jumpForce)
    {
        this.moveSpeed = moveSpeed;
        this.maxHealth = maxHealth;
        this.jumpForce = jumpForce;
    }
    Stats = new PlayerStats(5, 100, 5);
}

