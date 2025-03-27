using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Enemy enemy; //pretinieks
    public Player player; // speletajs
    public GameObject shield; // vairogs
    public int roundCounter; // raundu skaitītājs

    public TMP_Text playerName; // UI speletaja vards
    public TMP_Text enemyName; // UI pretinieka vārds
    public TMP_Text roundNo; // UI raunda numurs
    public TMP_Text playerHealth; // UI speletaja HP
    public TMP_Text enemyHealth;  // UI pretinieka HP

    void Start()
    {
        roundCounter = 0;
        SetPName(player.CharName);
        shield.SetActive(false);
        UpdateHealthUI();  // sakuma HP katram
    }

    public void RoundCounter()
    {
        roundCounter++;
        roundNo.text = "Round No: " + roundCounter;
    }

    public void SetPName(string NickName)
    {
        playerName.text = "Player: " + NickName;
    }

    public void Shield()
    {
        if (shield != null)
        {
            shield.SetActive(!shield.activeSelf);
        }
    }

    public void Round()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateHealthUI();  // Atjauninam HP pēc katra raunda
    }

    // Atjaunināšana
    public void UpdateHealthUI()
    {
        playerHealth.text = "Player HP: " + player.health;
        enemyHealth.text = "Enemy HP: " + enemy.health;
    }
}