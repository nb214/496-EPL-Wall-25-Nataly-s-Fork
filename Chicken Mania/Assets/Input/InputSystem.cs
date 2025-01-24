//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Input/InputSystem.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputSystem: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Click"",
            ""id"": ""c4f4a2f7-58a5-4a4f-aa9a-28a65b781035"",
            ""actions"": [
                {
                    ""name"": ""Touch"",
                    ""type"": ""Button"",
                    ""id"": ""1bcef70b-8c83-4bd7-8741-9bfdba94d2ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""30da5137-f6a4-4226-adf6-b2815f29f23d"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b60b9b96-39bf-451d-ac30-5bf0ec9a098b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Click
        m_Click = asset.FindActionMap("Click", throwIfNotFound: true);
        m_Click_Touch = m_Click.FindAction("Touch", throwIfNotFound: true);
    }

    ~@InputSystem()
    {
        UnityEngine.Debug.Assert(!m_Click.enabled, "This will cause a leak and performance issues, InputSystem.Click.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Click
    private readonly InputActionMap m_Click;
    private List<IClickActions> m_ClickActionsCallbackInterfaces = new List<IClickActions>();
    private readonly InputAction m_Click_Touch;
    public struct ClickActions
    {
        private @InputSystem m_Wrapper;
        public ClickActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Touch => m_Wrapper.m_Click_Touch;
        public InputActionMap Get() { return m_Wrapper.m_Click; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClickActions set) { return set.Get(); }
        public void AddCallbacks(IClickActions instance)
        {
            if (instance == null || m_Wrapper.m_ClickActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ClickActionsCallbackInterfaces.Add(instance);
            @Touch.started += instance.OnTouch;
            @Touch.performed += instance.OnTouch;
            @Touch.canceled += instance.OnTouch;
        }

        private void UnregisterCallbacks(IClickActions instance)
        {
            @Touch.started -= instance.OnTouch;
            @Touch.performed -= instance.OnTouch;
            @Touch.canceled -= instance.OnTouch;
        }

        public void RemoveCallbacks(IClickActions instance)
        {
            if (m_Wrapper.m_ClickActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IClickActions instance)
        {
            foreach (var item in m_Wrapper.m_ClickActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ClickActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ClickActions @Click => new ClickActions(this);
    public interface IClickActions
    {
        void OnTouch(InputAction.CallbackContext context);
    }
}
