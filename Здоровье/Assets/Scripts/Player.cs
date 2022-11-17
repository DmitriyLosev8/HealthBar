using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public float Health { get; private set; } = 50;

    public void GetDamage(float damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
        }
    }

    public void GetHeal(float numberOfHeal)
    {
        if(Health < 100)
        {
            Health += numberOfHeal;
        }      
    }

    private void Die()
    {
       Destroy(gameObject);
    }
}
