using System.Collections;
using System.Collections.Generic;
using AGEP.Project.Player;
using UnityEngine;

public class Gun : MonoBehaviour, IWeapon
{
    public GunAttributes gunAttributes;
   
    public Transform barrelEnd;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
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
        var _bullet = Instantiate(gunAttributes.Bullet);
        _bullet.transform.position = barrelEnd.position;
        // force
        _bullet.AddForce(Vector3.forward * gunAttributes.BulletSpeed, ForceMode.Impulse);
    }
}
