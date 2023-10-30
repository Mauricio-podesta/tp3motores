using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
  
    [SerializeField] GameObject Bulletprefab;
    [SerializeField] Transform SpawnPotition;
    [SerializeField] float BulletForce = 50f;
    [SerializeField] private int maxAmmo = 20;
    public Text maxAmmoTXT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && maxAmmo > 0)
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            maxAmmo = 20;
        
        }
        maxAmmoTXT.text = maxAmmo.ToString()+ " / 20";
    }
    private void Shoot()
    {
        
      GameObject NewBullet = Instantiate(Bulletprefab, SpawnPotition.position, Quaternion.identity);
      Rigidbody NewBulletRb = NewBullet.GetComponent<Rigidbody>();
      NewBulletRb.AddRelativeForce(transform.up*BulletForce, ForceMode.Impulse);
        Destroy(NewBullet, 2);
        maxAmmo -= 1;
    }
}
