using UnityEngine;
using System.Collections;
using ScriptableObjects;

namespace WeaponSystem
{
    public class Gun : MonoBehaviour, IWeapon
    {
        public GunAttributes gunAttributes;
        public GameObject bulletPrefab;

        public int ammoClips = 10;
        private int currentAmmo;
        public float reloadTime = 1f;
        private bool isReloading = false;
        
        public Transform barrelEnd;
        private GunAttributes Weapon; 
        public AudioSource audioSource;
      

        // Start is called before the first frame update
        void Start()
        {
            if(currentAmmo == 1)
                currentAmmo = ammoClips;
            audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            if (isReloading)
                return;
            
            if (currentAmmo <= 0)
            {
                StartCoroutine(ReloadWeapon());
                return;
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                audioSource.Play();
                ShootWeapon();
            }
        }
        
        

        public void ChangeWeapon()
        {
            Debug.Log("Weapon changed");
        }

        
        IEnumerator ReloadWeapon()
        {
            isReloading = true;
            Debug.Log("Weapon reloading");
            yield return new WaitForSeconds(reloadTime);
            currentAmmo = ammoClips;
            isReloading = false;
        }

        public void ShootWeapon()
        {
            currentAmmo--;
            Debug.Log("Weapon Fired");
            var bullet = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
            bullet.GetComponent<Rigidbody>().velocity = barrelEnd.forward * gunAttributes.BulletSpeed * gunAttributes.rateOfFire;
        }
    }
}
