using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothChangeHealth : MonoBehaviour
{
    [SerializeField] Slider _slider;

    private Coroutine _changeHealth;
    private float _recoveryRate = 10f;

    public void StartSmoothValueChange(float target)
    {
        _changeHealth = StartCoroutine(ChangeHealthBar(_slider.value + target));
    }

    private IEnumerator ChangeHealthBar(float target)
    {
        while (_slider.value != target)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, target, _recoveryRate * Time.deltaTime);

            yield return null;
        }
    }
}
