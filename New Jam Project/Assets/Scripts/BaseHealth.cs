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

            EndGame.GetComponent<EndGame>().Lose("��� �  ���� ����� ������, ���� ����� � ������� ����� ������������ � ��������, �������� ��� � ������� � ��������������.");
        }
        currentHealth += value;
        
        if(currentHealth <= 0)
        {

            EndGame.GetComponent<EndGame>().Lose("��� �  ���� ����� ������, ���� ����� � ������� ����� ������������ � ��������, �������� ��� � ������� � ��������������.");
        }
    }
    
    public int GetHealth()
    {
        return currentHealth;
    }

    
}
