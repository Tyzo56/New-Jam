using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float speed = 3f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(target.transform.position.x, target.position.y+5, target.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        int health = target.GetComponent<BaseHealth>().GetHealth();
        
        Vector3 position = target.position;
        position.y = transform.position.y;
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, 100+ target.position.y + 5 - health ,transform.position.z), position, speed * Time.deltaTime);
    }
}
