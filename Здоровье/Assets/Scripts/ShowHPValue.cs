using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ShowHPValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private float _speedOfValueChange = 0.5f;

    private void Start()
    {
        _slider.value = _player.Health;
    }

    public void ChangeHPValue()
    {
        float _targetValue = _player.Health;
        _slider.DOValue(_targetValue, _speedOfValueChange);
    }
}
