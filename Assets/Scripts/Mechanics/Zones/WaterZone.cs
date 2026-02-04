using UnityEngine;

public class WaterZone : Zone
{
    [Range (0f, 1f)]
    [SerializeField] private float speedModier = 0.5f;
    //Reduce the players speed by half
    protected override void ApplyZoneEffect(Player player)
    {
        //change my player's speed modifier value
        player.ApplySpeedModifier();
    }
}
