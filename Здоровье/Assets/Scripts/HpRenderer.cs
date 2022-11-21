using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HpRenderer : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private float _speedOfValueChange = 0.5f;

    private void Start()
    {
        _slider.value = _health.HpValue;
    }

    public void ChangeHPValue()
    {
        float targetValue = _health.HpValue;
        _slider.DOValue(targetValue, _speedOfValueChange);
    }
}
