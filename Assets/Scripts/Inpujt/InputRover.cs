// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inpujt/InputRover.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputRover : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputRover()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputRover"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""be9a9e1d-ec52-43a5-86f5-a40bb283f3ed"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ea63064c-7ccf-4abd-887d-1431fd647749"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""e9ff711c-84ad-4f8e-a41f-aeb872533a09"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""218370a8-6641-45f6-a66f-1ca9af36ccbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""02f53ae0-0e5e-4916-bb8f-96a856e2122e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f5178149-8300-4d4f-96ae-5c09393e7911"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b1775af8-db18-4704-9d59-19ddd5137e2c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ef918f93-4586-459b-9ad6-ccf1b484641c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""80f02a29-aa68-4364-9a3b-b2c00f2674d4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6239de25-1165-48ec-a902-8f21dd4771c0"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""801d100d-a2dd-43ad-b383-f0b97055b274"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""85643733-7d92-4d99-bd21-db07530a6da7"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3b71842-4582-4706-bde5-2ff6ad0d2a3b"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2da238f4-2c21-4d3e-9a82-cb4fdd632ba9"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cafcd0c8-165a-4846-92e7-3d7fb2f3ef1b"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""505c3c2e-debf-446e-9e96-0d77eca32f8e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb1eadd8-e80e-4c99-bd99-94e32ac5b57f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Movement = m_Move.FindAction("Movement", throwIfNotFound: true);
        m_Move_Look = m_Move.FindAction("Look", throwIfNotFound: true);
        m_Move_Reset = m_Move.FindAction("Reset", throwIfNotFound: true);
        m_Move_Interact = m_Move.FindAction("Interact", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Movement;
    private readonly InputAction m_Move_Look;
    private readonly InputAction m_Move_Reset;
    private readonly InputAction m_Move_Interact;
    public struct MoveActions
    {
        private @InputRover m_Wrapper;
        public MoveActions(@InputRover wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Move_Movement;
        public InputAction @Look => m_Wrapper.m_Move_Look;
        public InputAction @Reset => m_Wrapper.m_Move_Reset;
        public InputAction @Interact => m_Wrapper.m_Move_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Reset.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnReset;
                @Interact.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    public interface IMoveActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
