using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 
     public Sprite hitEffect;

   void OnCollisionEnter2D(Collision2D collision)
   {
       Sprite effect =Instantiate(hitEffect, transform.position, Quaternion.identity);
       Destroy(effect, 2f);
       Destroy(gameObject);

   }
}
