using UnityEngine;

namespace WeaponSystem
{
    public class PickupGun: MonoBehaviour
    {
        public GameObject gun;
        public GameObject bullet;
        public Camera Camera;

        void Update()
        {
            //To cast an action
            RaycastHit hit;
            Ray r = new Ray(Camera.transform.position, Camera.transform.forward);

            //
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.transform.tag == "item")
                {
                    IPickupWeapon gunInfo = hit.transform.GetComponent<IPickupWeapon>();
                    if (gunInfo != null)
                    {
                        //If the item has a gun script on it, get the mesh and bullet info
                        //ShootWeapon();
                    }


                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}