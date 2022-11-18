using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _numberOfHeal = 10;

    public void Heal()
    {
        _player.RaiseHealthValue(_numberOfHeal);
    }
}
