using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float gravity = -9.81f;
    public float verticalSpeed;
    float horizontalMove;
    float verticalMove;
    private CharacterController charController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        if (charController.isGrounded == true)
        {
            verticalSpeed = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalSpeed = 3f;
            }
        }

        verticalSpeed += gravity * Time.deltaTime;

        Vector3 direction = new Vector3(horizontalMove, verticalSpeed, verticalMove);
        charController.Move(direction * moveSpeed * Time.deltaTime);
    }
}
