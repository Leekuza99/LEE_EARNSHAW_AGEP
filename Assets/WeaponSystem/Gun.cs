using UnityEngine;


namespace WeaponSystem
{
    public class Gun : MonoBehaviour, IWeapon
    {
        public GunAttributes gunAttributes;
        public GameObject bulletPrefab;
   
        public Transform barrelEnd;
        private GunAttributes Weapon; 
        AudioSource shootingSound;

        // Start is called before the first frame update
        void Start()
        {
            shootingSound = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                shootingSound.Play();
                ShootWeapon();
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
            var bullet = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
            bullet.GetComponent<Rigidbody>().velocity = barrelEnd.forward * gunAttributes.BulletSpeed * gunAttributes.rateOfFire;
        }
    }
}
