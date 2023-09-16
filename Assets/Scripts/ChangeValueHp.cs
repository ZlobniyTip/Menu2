using UnityEngine;
using UnityEngine.UI;

public class ChangeValueHp : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private SmoothChangeHealth _smoothChangeHealth;

    private Coroutine _changeHealth;

    private int _heal = 10;
    private int _damage = 10;

    public void TakeDamage()
    {
        _changeHealth = StartCoroutine(_smoothChangeHealth.ChangeHealthBar(_slider.value - _damage));
    }

    public void TakeHeal()
    {
        _changeHealth = StartCoroutine(_smoothChangeHealth.ChangeHealthBar(_slider.value + _heal));
    }
}
