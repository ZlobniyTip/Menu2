using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private ChangeValue _buttonDamage;
    [SerializeField] private ChangeValue _buttonHeal;
    [SerializeField] private Text _text;

    private Coroutine _changeHealth;
    private float _recoveryRate = 10f;

    public void ShowHealth(float value)
    {
        _text.text = _slider.value.ToString();
    }

    private IEnumerator ChangeHealthBar(float target)
    {
        while (_slider.value != target)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, target, _recoveryRate * Time.deltaTime);

            yield return null;
        }
    }

    public void TakeDamage()
    {
        _changeHealth = StartCoroutine(ChangeHealthBar(_slider.value - _buttonDamage.Damage));
    }

    public void TakeHeal()
    {
        _changeHealth = StartCoroutine(ChangeHealthBar(_slider.value + _buttonDamage.Heal));
    }
}
