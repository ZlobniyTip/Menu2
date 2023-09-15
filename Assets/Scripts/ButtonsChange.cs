using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsChange : MonoBehaviour
{
    [SerializeField] Slider _slider;

    private Coroutine _changeHealth;
    private float _recoveryRate = 10f;
    private int _heal = 10;
    private int _damage = 10;

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
        _changeHealth = StartCoroutine(ChangeHealthBar(_slider.value - _damage));
    }

    public void TakeHeal()
    {
        _changeHealth = StartCoroutine(ChangeHealthBar(_slider.value + _heal));
    }
}
