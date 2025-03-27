using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public int health; // charactera dzīvības
    public bool isDead = false; // boleans tam lai zināt vai characters ir miris
    public Character target; // characters TARGETS
    public Weapon currentWeapon; // ierocis

    private IEnumerator EnemyCounterAttack(Character player) // Pārbaude uz to vai spēlētājs nav miris
    {
        if (!player.isDead)
        {
            yield return new WaitForSeconds(1f); // gaida 1 sek.
            target.Attack(player);  
        }

        yield break;
    }

    public void PlayerAttack()
    {
        if (!isDead && !target.isDead) // ja characters nav miris un target nav miris
        {
            Attack(target);  
        }
    }

    public virtual void Attack(Character target)
    {
        if (isDead)
        {
            Debug.Log(name + " is dead and can't attack."); // Ja tas kurš uzbrūk ir miris
            return;
        }

        if (target.isDead)
        {
            Debug.Log(name + " can't attack, opponent is dead."); // Ja tas UZ KURU uzbrūk ir miris
            return;
        }

        // = = = Sistēma tam lai sistu ar roku (UI Change Weapon)
        int damage = currentWeapon != null ? currentWeapon.GetAttack() : 2; // Ja characteram nav ieroča, tas uzbrūk ar 2 damage (ļoti maz)

        Debug.Log(name + " is attacking " + target.name + "!"); // attack teksts
        target.GetHit(damage);
    }

    public virtual void GetHit(int damage)
    {
        if (isDead) return;

        health -= damage;
        Debug.Log(name + " took " + damage + " damage!");

        FindObjectOfType<GameManager>().UpdateHealthUI(); // Atjauninam UI pēc uzbrukuma

        if (health <= 0)
        {
            isDead = true;
            Debug.Log(name + " has died!");
        }
    }
}