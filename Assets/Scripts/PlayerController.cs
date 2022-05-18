using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AGEP.Project.Player
{
    public class PlayerController : MonoBehaviour, IWeapon
    {
        public CharacterController controller;

        public float speed = 12f;
        public float gravity = -9.81f;
        public float jumpHeight = 3f;

        public Transform groundCheck;
        public float groundDistance = 0.4f;
        public LayerMask groundmask;
        
        Vector3 velocity;
        bool isGrounded;
        
        public IWeapon weapon;
        // Update is called once per frame
        void Update()
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

            if(isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if(Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); 
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
            WeaponHandler();
            
        }

        void WeaponHandler()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeWeapon();
            }
            
            if (Input.GetKeyDown(KeyCode.F))
            {
                PickupWeapon();
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                ReloadWeapon();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                ShootWeapon();
            }
        }
            

        public void ChangeWeapon()
        {
            weapon.ChangeWeapon();
        }

        public void PickupWeapon()
        {
            weapon.PickupWeapon();
        }

        public void ReloadWeapon()
        {
           weapon.ReloadWeapon();
        }

        public void ShootWeapon()
        {
            weapon.ShootWeapon();
        }
    }
}
