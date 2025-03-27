using UnityEngine;

public class Player : Character
{
    public string CharName;
    public GameObject deathScreen;
    public GameObject shield;

    public void Start()
    {
        if (deathScreen != null)
        {
            deathScreen.SetActive(false);
        }
    }

    public override void GetHit(int damage)
    {
        if (shield != null && shield.activeSelf) 
        {
            damage = Mathf.RoundToInt(damage * 0.5f); // samazina damage uz 50% kā arī noapaļo skaitli līdz int
            Debug.Log("Shield is active! Damage reduced to: " + damage); // izvada saņemto damage jau ar vairoga iedarbību
        }

        base.GetHit(damage); // standarta gethit

        if (isDead && deathScreen != null)
        {
            deathScreen.SetActive(true); // parādam deathscreen
        }
    }
}