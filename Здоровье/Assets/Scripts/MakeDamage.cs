using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _numberOfDamage = 10;

    public void DoDamage()
    {
        _player.GetDamage(_numberOfDamage);
    }
}
