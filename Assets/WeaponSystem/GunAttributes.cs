using UnityEngine;

namespace WeaponSystem
{
    [CreateAssetMenu(fileName = "GunType", menuName = "Gun Type", order = 0)]
    public class GunAttributes : ScriptableObject
    {
        public float RateOfFire = 1f; //Number of bullets fired per seconds.
        public float BulletSpeed = 1f; //Speed of bullets.
        public bool MachineGunFire = true;
        public AudioClip gunSound;
        public int ammoClips = 1;
        public string nameOfGun = "default gun";
        public Rigidbody Bullet;

    }
}