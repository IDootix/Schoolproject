using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersonMovement : MonoBehaviour
{
   public CharacterController controller;
   public Transform cam;
   public float speed = 6f;
   public float jumpForce = 2.0f;

   public float turnSmoothTime = 0.1f;
   float trunSmoothVelocity;

   public float CurrentHealth;
   public float MaxHealth = 100f;
   public float HealthRegen = 0.3f;


   void Start()
   {  
        CurrentHealth = MaxHealth;
   }    

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref trunSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            controller.Move(Vector3.up * jumpForce);
        }

        if (CurrentHealth < MaxHealth)
        {
            CurrentHealth += HealthRegen * Time.deltaTime;
        }
    }             
}
