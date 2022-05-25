using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDonePlayer : MonoBehaviour
{
    [SerializeField] int damageP = 25;

    public int GetDamageE(){
        return damageP;
    }

    public void HitP(){
        Destroy(gameObject);
    }
}
