using UnityEngine;

public class Op4Movement : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 3.5f;
    public float jumpForce = 8f;

    [Header("Components")]

    [SerializeField] private Rigidbody rb;
    public Op4ScoreManager scoreManager;

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 newPosition = transform.position + movement * speed * Time.deltaTime;
        rb.MovePosition(newPosition);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
