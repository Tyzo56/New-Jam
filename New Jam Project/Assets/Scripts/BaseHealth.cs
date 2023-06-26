using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private GameObject EndGame;

    public virtual void ReccountHealth(int value)
    {
        if (currentHealth <= 0)
        {

            EndGame.GetComponent<EndGame>().Lose("Как и  этот кубик сахара, наши мечты и желания могут растворяться и исчезать, оставляя нас с горечью и разочарованием.");
        }
        currentHealth += value;
        
        if(currentHealth <= 0)
        {

            EndGame.GetComponent<EndGame>().Lose("Как и  этот кубик сахара, наши мечты и желания могут растворяться и исчезать, оставляя нас с горечью и разочарованием.");
        }
    }
    
    public int GetHealth()
    {
        return currentHealth;
    }

    
}
