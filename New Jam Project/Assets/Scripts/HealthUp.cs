using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    [SerializeField] private string targetTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == targetTag)
        {
            int health = 100 - collision.gameObject.GetComponent<BaseHealth>().GetHealth();

            collision.gameObject.GetComponent<BaseHealth>().ReccountHealth(health);
        }
    }
}
