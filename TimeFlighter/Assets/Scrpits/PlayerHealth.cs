using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  [SerializeField] int playerhealth = 150;

 void OnTriggerEnter2D(Collider2D other) {
     DamageDoneEnemies damageDoneEnemies = other.GetComponent<DamageDoneEnemies>();
    
    if (damageDoneEnemies != null)
    {
        TakeDamageP(damageDoneEnemies.GetDamageE());
        damageDoneEnemies.HitE();
    }
  }

  void  TakeDamageP(int damageE){
      playerhealth -= damageE;
      if (playerhealth <= 0)
      {
         Destroy(gameObject); 
      }
  }

}
