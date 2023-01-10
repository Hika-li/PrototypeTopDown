using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CanonManager _canon;
    private Vector2 _direction;
    private CharacterController _characterController;
    public float speedPlayer = 10f;
    public float rotationSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = new Vector3(0f, 0f, _direction.y); // référentiel par défaut c'est le monde 
        forward = transform.TransformDirection(forward); // faire devenir le référentiel de notre vecteur comme celui de notre PERSONNAGE !
        _characterController.Move(forward * speedPlayer * Time.deltaTime);
        transform.Rotate(transform.up, _direction.x * rotationSpeed * Time.deltaTime ); // vecteur vertical et la valeur
    }
    
    //TODO: Tirer les projectiles
    public void OnShoot(InputAction.CallbackContext p_context)
    {
        _canon.Shoot();
    }
    
    
    public void OnMovement(InputAction.CallbackContext p_context)
    {
        _direction = p_context.ReadValue<Vector2>();
    }

}
