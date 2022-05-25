using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
  [SerializeField] int basehealth = 300;

 void OnTriggerEnter2D(Collider2D other) {
     DamageDoneEnemies damageDoneEnemies = other.GetComponent<DamageDoneEnemies>();
    
    if (damageDoneEnemies != null)
    {
        TakeDamageP(damageDoneEnemies.GetDamageE());
        damageDoneEnemies.HitE();
    }
  }

  void  TakeDamageP(int damageE){
      basehealth -= damageE;
      if (basehealth <= 0)
      {
         Destroy(gameObject); 
      }
  }

}
