using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInstantiate : MonoBehaviour
{
    public Rigidbody Bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(Bullet);
        }
    }
}
