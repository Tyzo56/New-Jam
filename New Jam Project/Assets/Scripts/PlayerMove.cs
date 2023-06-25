using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float inputX, inputY;
    private Rigidbody rb;

    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        Vector3 input = new Vector3(inputX, 0f, inputY);


        // transform.position += input * Time.deltaTime * speed;

        int health = transform.GetComponent<BaseHealth>().GetHealth();

        rb.mass = health * 0.009f;

        rb.AddForce(new Vector3(0f,0f,3f) * inputY * speed, ForceMode.Impulse);
        rb.AddForce(new Vector3(3f, 0f, 0f) * inputX * speed, ForceMode.Impulse);

    }
}
