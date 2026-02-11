using UnityEngine;

public class GravityZone : Zone
{
    protected override void ApplyZoneEffect(Player player)
    {
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            SpriteRenderer sr = player.GetComponent<SpriteRenderer>();

            rb.gravityScale *= -1;

            sr.flipY = !sr.flipY;
        }
    }
