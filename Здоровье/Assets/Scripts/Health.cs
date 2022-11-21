using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _numberOfValueChange = 10; 
    public float HpValue { get; private set; } = 50;
    
    public void MakeDamage()
    {
        int minHpValue = 0;

        if (HpValue > minHpValue)
        {
            HpValue -= _numberOfValueChange;
        }
    }

    public void Heal()
    {
        int maxHpValue = 100;

        if (HpValue < maxHpValue)
        {
            HpValue += _numberOfValueChange;
        }
    }
}
