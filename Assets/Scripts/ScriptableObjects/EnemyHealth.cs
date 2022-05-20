using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "EnemyHealth", menuName = "ScriptableObjects/EnemyHealth", order = 0)]
    public class EnemyHealth : ScriptableObject
    {
        public float prefabHealth;
    }
}