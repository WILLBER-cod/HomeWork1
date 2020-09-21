using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _health;

    private void Update()
    {
        _health = _slider.value;
    }

    public void Add( float AddValue)
    {
        _slider.DOValue(_health + AddValue, 0.5f).SetEase(Ease.Linear);
    }

    public void Substract( float SubstractValue)
    {
        _slider.DOValue(_health - SubstractValue, 0.5f).SetEase(Ease.Linear);
    }
}
