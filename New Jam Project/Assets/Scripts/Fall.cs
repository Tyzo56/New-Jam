using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    [SerializeField] private GameObject EndGame;

    private void OnCollisionEnter(Collision collision)
    {
        print("упал");
        EndGame.GetComponent<EndGame>().Lose("Падающий кубик сахара - словно нота в музыкальной партитуре жизни, которая иногда звучит ломаным звуком, напоминая о невыполненных мечтах и разбитых надеждах.");
    }
}
