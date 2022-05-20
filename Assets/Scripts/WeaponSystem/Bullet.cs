using UnityEngine;

namespace WeaponSystem
{
    public class Bullet : MonoBehaviour
    {
        public float DestroyDelay = 100;

        public int damageAmount = 10;
        void Awake()
        {
            Destroy(gameObject, DestroyDelay);
        }
    
    

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.SendMessage("Damage", damageAmount);
            }
            Destroy(this.gameObject);
        }
    }
}