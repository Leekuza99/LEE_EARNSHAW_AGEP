using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "GunType", menuName = "Gun Type", order = 0)]
    public class GunAttributes : ScriptableObject
    {
        public float rateOfFire = 1f; //Number of bullets fired per seconds.
        public float BulletSpeed = 1f; //Speed of bullets.
        public int ammoClips = 10;
        private int currentAmmo;
        public float gunDamage = 2f;

    }
}