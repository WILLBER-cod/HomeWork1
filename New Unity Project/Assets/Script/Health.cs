using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _health;
    private float _addHealth;
    private float _substractHealth;

    private void Update()
    {
        _health = _slider.value;
    }

    public void Add()
    {
        _addHealth = _health + 10;

        _slider.DOValue(_addHealth, 0.5f).SetEase(Ease.Linear);
    }

    public void Substract()
    {
        _substractHealth = _health - 10;

        _slider.DOValue(_substractHealth, 0.5f).SetEase(Ease.Linear);
    }
}
