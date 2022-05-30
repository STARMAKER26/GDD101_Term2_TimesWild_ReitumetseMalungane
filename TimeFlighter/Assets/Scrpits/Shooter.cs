using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
 public Transform firePoint;
 public GameObject bulletPrefab;

 public float bulletForce = 20f;

void Update()
 {
     if (Input.GetButtonDown("Fire1"))
     {
         Shoot();
     }
 }

 void Shoot(){
     GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation );
     Rigidbody2D _myRigidbody =  bullet.GetComponent<Rigidbody2D>();
     _myRigidbody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
 }

}
