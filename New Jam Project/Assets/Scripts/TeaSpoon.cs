using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaSpoon : MonoBehaviour
{
    [SerializeField] private float existTime;
   

    private void Update()
    {
        existTime -= 1 * Time.deltaTime;
        if (existTime <= 0)
        {
            Destroy(transform.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("EndGame").GetComponent<EndGame>().Win();
        print("צרע");
    }

    private void Win()
    {
        print("win!");
    }
}
