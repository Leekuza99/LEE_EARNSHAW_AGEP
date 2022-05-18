using UnityEngine;


namespace WeaponSystem
{
    public class Gun : MonoBehaviour, IWeapon
    {
        public GunAttributes gunAttributes;
        public GameObject bulletPrefab;
   
        public Transform barrelEnd;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                var bullet = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
                bullet.GetComponent<Rigidbody>().velocity = barrelEnd.forward * gunAttributes.BulletSpeed;
            }
        }
        
        

        public void ChangeWeapon()
        {
            Debug.Log("Weapon changed");
        }

        public void PickupWeapon()
        {
            Debug.Log("Weapon picked up");
            
        }

        public void ReloadWeapon()
        {
            Debug.Log("Weapon reloaded");
        }

        public void ShootWeapon()
        {
            Debug.Log("Weapon Fired");
            /*var _bullet = Instantiate(gunAttributes.Bullet);
            _bullet.transform.position = barrelEnd.position;
            _bullet.AddForce(Vector3.forward * gunAttributes.BulletSpeed, ForceMode.Impulse);
            if (Input.GetKeyDown(KeyCode.Q))*/
            {
                //Instantiate (_bullet,)
            }
        }
    }
}
