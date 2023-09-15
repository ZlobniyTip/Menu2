using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private ChangeValue _buttonDamage;
    [SerializeField] private ChangeValue _buttonHeal;
    [SerializeField] private Text _text;

    public void ShowHealth(float value)
    {
        _text.text = _slider.value.ToString();
    }

    public void TakeDamage()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _slider.value - _buttonDamage.Damage, _buttonDamage.Damage);
    }

    public void TakeHeal()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _slider.value + _buttonHeal.Heal, _buttonHeal.Heal);
    }
}
