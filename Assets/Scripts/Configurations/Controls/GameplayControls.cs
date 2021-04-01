// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Configurations/Controls/GameplayControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameplayControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameplayControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""aee1e141-00b5-49a6-bf5f-4d614c3729da"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2c573021-4ac8-43b0-888b-590f44315b47"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightHandFire"",
                    ""type"": ""Button"",
                    ""id"": ""c9855dcb-fa32-4bff-959c-d7c62c298e6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftHandFire"",
                    ""type"": ""Button"",
                    ""id"": ""365c97d8-a36d-4e05-b2e7-1522341ef774"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BulletCycle"",
                    ""type"": ""Value"",
                    ""id"": ""7601af2a-9c99-44ad-94b0-bcc9e840c510"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d1d6d6d8-1002-4cb7-9f93-2b3c8eaeb399"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1.5)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""a854b8e2-f822-47c9-be77-756c8fd52b61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5916c78c-3f1b-467f-bae8-82898fb5b041"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""cf1939a4-651f-4a49-a117-7d40021d6f86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f1201b56-65ca-4f29-888f-4ad09040b287"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c91c932f-48be-426a-9168-cf425bbbc1e2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""444c349a-6095-4b4a-8394-ad6a619fbbd4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fdf20b1f-5eac-4ca2-84a1-6deb49747dda"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5bba930d-ac1e-4ad7-802f-d1232c34e502"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""154ab720-3fd1-4e9d-aa51-35fd00065d4f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHandFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5262e4fe-7564-408e-bfb3-6a4a620a19d6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHandFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""908f3c18-ff00-4af9-8f31-a6694250443b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1823674-af45-473f-b02f-a670ff75c1f3"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BulletCycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34017901-a274-40f8-b7d5-52a7354c97ef"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afa1e70e-7458-43d8-914b-94c65f2c5fc0"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a89eae9a-7c13-4fe2-9046-b3fbc7c95094"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_RightHandFire = m_Gameplay.FindAction("RightHandFire", throwIfNotFound: true);
        m_Gameplay_LeftHandFire = m_Gameplay.FindAction("LeftHandFire", throwIfNotFound: true);
        m_Gameplay_BulletCycle = m_Gameplay.FindAction("BulletCycle", throwIfNotFound: true);
        m_Gameplay_Reload = m_Gameplay.FindAction("Reload", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_CameraControl = m_Gameplay.FindAction("CameraControl", throwIfNotFound: true);
        m_Gameplay_Dodge = m_Gameplay.FindAction("Dodge", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_RightHandFire;
    private readonly InputAction m_Gameplay_LeftHandFire;
    private readonly InputAction m_Gameplay_BulletCycle;
    private readonly InputAction m_Gameplay_Reload;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_CameraControl;
    private readonly InputAction m_Gameplay_Dodge;
    public struct GameplayActions
    {
        private @GameplayControls m_Wrapper;
        public GameplayActions(@GameplayControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @RightHandFire => m_Wrapper.m_Gameplay_RightHandFire;
        public InputAction @LeftHandFire => m_Wrapper.m_Gameplay_LeftHandFire;
        public InputAction @BulletCycle => m_Wrapper.m_Gameplay_BulletCycle;
        public InputAction @Reload => m_Wrapper.m_Gameplay_Reload;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @CameraControl => m_Wrapper.m_Gameplay_CameraControl;
        public InputAction @Dodge => m_Wrapper.m_Gameplay_Dodge;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @RightHandFire.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightHandFire;
                @RightHandFire.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightHandFire;
                @RightHandFire.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightHandFire;
                @LeftHandFire.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftHandFire;
                @LeftHandFire.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftHandFire;
                @LeftHandFire.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftHandFire;
                @BulletCycle.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBulletCycle;
                @BulletCycle.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBulletCycle;
                @BulletCycle.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBulletCycle;
                @Reload.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @CameraControl.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraControl;
                @Dodge.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDodge;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RightHandFire.started += instance.OnRightHandFire;
                @RightHandFire.performed += instance.OnRightHandFire;
                @RightHandFire.canceled += instance.OnRightHandFire;
                @LeftHandFire.started += instance.OnLeftHandFire;
                @LeftHandFire.performed += instance.OnLeftHandFire;
                @LeftHandFire.canceled += instance.OnLeftHandFire;
                @BulletCycle.started += instance.OnBulletCycle;
                @BulletCycle.performed += instance.OnBulletCycle;
                @BulletCycle.canceled += instance.OnBulletCycle;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRightHandFire(InputAction.CallbackContext context);
        void OnLeftHandFire(InputAction.CallbackContext context);
        void OnBulletCycle(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
    }
}
