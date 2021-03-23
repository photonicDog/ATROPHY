using Assets.Scripts.Gameplay.Input;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float playerSpeed = 3.0f;
    [SerializeField]
    public float playerJumpGravity = -9.8f;
    [SerializeField]
    public float playerJumpHeight = 2.0f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded;
    private InputManager inputManager;
    private Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
        inputManager = InputManager.Instance;
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(controller.bounds.center, Vector3.down, controller.bounds.extents.y + 0.3f);
        if (isGrounded && playerVelocity.y < 0f)
        {
            playerVelocity.y = 0f;
        }

        var movement = inputManager.GetPlayerMovement();
        var move = new Vector3(movement.x, 0f, movement.y);
        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        move.y = 0f;
        controller.Move(move * Time.deltaTime * playerSpeed);

        if(inputManager.Jumped() && isGrounded)
        {
            playerVelocity.y += Mathf.Sqrt(playerJumpHeight * -3.0f * playerJumpGravity);
        }

        playerVelocity.y += playerJumpGravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
