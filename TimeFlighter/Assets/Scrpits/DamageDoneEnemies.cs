using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDoneEnemies : MonoBehaviour
{
    [SerializeField] int damageE = 25;

    public int GetDamageE(){
        return damageE;
    }

    public void HitE(){
        Destroy(gameObject);
    }
}
