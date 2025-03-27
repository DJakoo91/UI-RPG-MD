using UnityEngine;

public class ChangeWeapon: MonoBehaviour
{
    public GameObject sword;  // Speletaja galvenais ierocis
    private GameObject storedSword;  // mainigais lai saglabāt speletaja galveno ieroci

    public void ToggleObj()
    {
        if (sword != null) 
        {
            storedSword = sword; // saglabā objektu mainīgajā
            sword.SetActive(false); // izslēdzam objektu
            sword = null; // pielīdzinam objektu ar NULL
            Debug.Log("You selected to fight with your hands!");
        }
        else if (storedSword != null) 
        {
            sword = storedSword; // atjauninam objektu
            sword.SetActive(true); // ieslēdzam objektu
            Debug.Log("You pulled out you sword again!");
        }
    }
}