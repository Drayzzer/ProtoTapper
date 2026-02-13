using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public static event Action<bool> OnInputDeviceChanged;
            
    [SerializeField] private GameObject _player;
    
    private PlayerInput _playerInput;
    private PlayerController  _playerController;
    private bool _isControllerConnected;
        
    
    private void Awake() {
        _playerInput = _player.GetComponent<PlayerInput>();   
        _playerController= _player.GetComponent<PlayerController>();   
    }
        
    private void OnEnable()
    {
        // Bind input actions
        InputSystem.onDeviceChange += OnDeviceChange;
        _playerInput.actions["Move"].performed += OnMove;
        
        DetectCurrentInputDevice();
    }
    
    private void OnDisable()
    {
        InputSystem.onDeviceChange -= OnDeviceChange;
        _playerInput.actions["Move"].canceled -= OnMove;
    }
        
    private void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        if (change == InputDeviceChange.Added || change == InputDeviceChange.Removed)
        {
            DetectCurrentInputDevice();
        }
    }
    
    private void DetectCurrentInputDevice()
    {
        _isControllerConnected = Gamepad.all.Count > 0;
        OnInputDeviceChanged?.Invoke(_isControllerConnected);
    }
    
    private void OnMove(InputAction.CallbackContext context)
    {
        _playerController.Move = context.ReadValue<Vector2>();
    }
}
