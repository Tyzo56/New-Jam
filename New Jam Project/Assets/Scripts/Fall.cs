using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    [SerializeField] private GameObject EndGame;

    private void OnCollisionEnter(Collision collision)
    {
        print("����");
        EndGame.GetComponent<EndGame>().Lose("�������� ����� ������ - ������ ���� � ����������� ��������� �����, ������� ������ ������ ������� ������, ��������� � ������������� ������ � �������� ��������.");
    }
}
