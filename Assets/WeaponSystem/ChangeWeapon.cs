using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    public GameObject[] weapons;
  

    int weaponCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        weapons[0].SetActive(true);
        weapons[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            weaponCounter = 0;

            for(int i = 0; i < weapons.Length; i++)
            {
                if (i != weaponCounter)
                    weapons[i].SetActive(false);
                else
                    weapons[i].SetActive(true);
            }        
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            weaponCounter = 1;

            for (int i = 0; i < weapons.Length; i++)
            {
                if (i != weaponCounter)
                    weapons[i].SetActive(false);
                else
                    weapons[i].SetActive(true);
            }
        }
    }
}