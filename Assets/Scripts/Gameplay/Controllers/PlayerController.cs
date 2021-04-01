using Assets.Scripts.Gameplay.Input;
using System.Collections;
using UnityEditor;
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
    [SerializeField]
    public AnimationCurve dodgeSpeed;
    [SerializeField]
    public float dodgeDuration = 1;
    [SerializeField]
    public AnimationCurve postDodgeSlow;
    [SerializeField]
    public float postDodgeSlowDuration = 2;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded;
    private InputManager inputManager;
    private Transform cameraTransform;
    private bool isDodge = false;
    private Vector3 dodgeDirection;
    private float speedMod = 1;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
        inputManager = InputManager.Instance;
        cameraTransform = Camera.main.transform;
    }
    void OnGUI()
    {
        //dodgeSpeed = EditorGUILayout.CurveField("Dodge speed", dodgeSpeed);
        //postDodgeSlow = EditorGUILayout.CurveField("Dodge slow", postDodgeSlow);
    }

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

        if (inputManager.Dodged() && !isDodge)
        {
            isDodge = true;
            dodgeDirection = move;
            StartCoroutine(Dodge());
        }

        controller.Move(move * Time.deltaTime * playerSpeed * speedMod);

        if(inputManager.Jumped() && isGrounded)
        {
            playerVelocity.y += Mathf.Sqrt(playerJumpHeight * -3.0f * playerJumpGravity);
        }

        playerVelocity.y += playerJumpGravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    IEnumerator Dodge()
    {
        var startDodgeTime = Time.time;
        var currentDodgeDuration = startDodgeTime + dodgeDuration;
        while (Time.time < currentDodgeDuration)
        {
            var time = dodgeSpeed.length * ((Time.time - startDodgeTime) / currentDodgeDuration);
            Debug.Log(dodgeSpeed.Evaluate(time));
            controller.Move(dodgeDirection * Time.deltaTime * dodgeSpeed.Evaluate(time));
            yield return new WaitForEndOfFrame();
        }

        while(!isGrounded)
        {
            yield return new WaitForEndOfFrame();
        }

        var startSlowTime = Time.time;
        var currentSlowDuration = startSlowTime + postDodgeSlowDuration;
        while (Time.time < currentSlowDuration)
        {
            var time = postDodgeSlow.length * ((Time.time - startSlowTime) / currentSlowDuration);
            Debug.Log(postDodgeSlow.Evaluate(time));
            speedMod = postDodgeSlow.Evaluate(time);
            yield return new WaitForEndOfFrame();
        }

        speedMod = 1;
        isDodge = false;
    }
}
