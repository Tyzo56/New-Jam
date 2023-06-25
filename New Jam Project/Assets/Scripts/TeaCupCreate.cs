using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaCupCreate : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints = new List<Transform>();
    [SerializeField] private GameObject cupPrefab;
    [SerializeField] private float spawnTime;

    private void Start()
    {
        InvokeRepeating(nameof(CreateCup), 0f, spawnTime);
    }

    void CreateCup()
    {
        int randomIndex = Random.Range(0, spawnPoints.Count);
        Instantiate(cupPrefab, spawnPoints[randomIndex].position, Quaternion.identity);

    }
}
