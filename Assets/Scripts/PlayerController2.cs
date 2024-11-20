using UnityEngine;
public class PlayerController2 : MonoBehaviour{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    public float jumpForce = 20f; // Force for jumping
    private float xInput;
    private float zInput;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessInputs();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        // Check for jump input
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0, zInput) * moveSpeed);
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
    }
}
