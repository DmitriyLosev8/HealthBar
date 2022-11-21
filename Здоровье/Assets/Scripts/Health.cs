using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HpValue { get; private set; } = 50;
    private float _numberOfValueChange = 10;

    public void DownGradeHpValue()
    {
        HpValue -= _numberOfValueChange;
    }

    public void RaiseHpValue()
    {
        int maxHpValue = 100;

        if (HpValue < maxHpValue)
        {
            HpValue += _numberOfValueChange;
        }
    }
}
