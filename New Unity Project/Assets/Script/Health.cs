using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private float _health;

    private void Update()
    {
        _slider.value = _health;
    }

    public void Add()
    {
        _health += 10;
    }

    public void Substract()
    {
        _health -= 10;
    }
}
