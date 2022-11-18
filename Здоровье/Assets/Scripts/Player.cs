using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public float Health { get; private set; } = 50;

    public void DownGradeHealthValue(float damage)
    {
        int minHealthValue = 0;
       
        Health -= damage;
        if (Health <= minHealthValue)
        {
            Die();
        }
    }

    public void RaiseHealthValue(float numberOfHeal)
    {
        int maxHealthValue = 100;
        
        if(Health < maxHealthValue)
        {
            Health += numberOfHeal;
        }      
    }

    private void Die()
    {
       Destroy(gameObject);
    }
}
