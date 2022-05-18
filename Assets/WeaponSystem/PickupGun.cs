using UnityEngine;

namespace WeaponSystem
{
    public class PickupGun : MonoBehaviour
    {
        public float distance = 10f;
        public Transform equipPosition;
        GameObject currentWeapon;

        bool canGrab;



        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            CheckGrab();

            if (canGrab)
            {
                if (Input.GetKeyDown(KeyCode.T))

                    PickUp();

            }
        }

        private void CheckGrab()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {
                if (hit.transform.tag == "CanGrab")
                {
                    currentWeapon = hit.transform.gameObject;
                    canGrab = true;
                }

            }
            else
                canGrab = false;

        }

        private void PickUp()
        {
            currentWeapon.transform.position = equipPosition.position;
            currentWeapon.transform.parent = equipPosition;
            currentWeapon.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
            currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
            currentWeapon.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
}