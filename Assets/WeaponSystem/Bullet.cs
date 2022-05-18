using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Time = 100;
    public GameObject EnemyPrefab;

    void Awake()
    {
        Destroy(EnemyPrefab, Time);
    }
    
    

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(EnemyPrefab);
        
    }
}