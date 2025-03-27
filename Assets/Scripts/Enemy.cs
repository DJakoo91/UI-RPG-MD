using UnityEngine;

public class Enemy : Character
{
    public override void GetHit(int damage)
    {
        base.GetHit(damage); // standarta damage

        if (isDead)
        {
            Debug.Log(name + " (Enemy) has been defeated!");
        }
    }
}