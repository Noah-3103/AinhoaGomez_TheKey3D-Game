using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float moveSpeed = 5f;
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
        Vector3 direction = new Vector3(horizontalMove, 0, verticalMove);
        charController.Move(direction * moveSpeed * Time.deltaTime);
    }
}
