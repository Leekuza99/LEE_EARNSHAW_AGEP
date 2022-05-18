using UnityEngine;

namespace WeaponSystem
{
    [CreateAssetMenu(fileName = "GunType", menuName = "Gun Type", order = 0)]
    public class GunAttributes : ScriptableObject
    {
        public float rateOfFire = 1f; //Number of bullets fired per seconds.
        public float BulletSpeed = 1f; //Speed of bullets.
        public bool machineGunFire = true;
        public AudioClip gunSound;
        public int ammoClips = 1;
        public string nameOfGun = "Weapon";
        public string nameOfGun2 = "Gun2";
        
        public Rigidbody Bullet;

    }
}