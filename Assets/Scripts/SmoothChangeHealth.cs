using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothChangeHealth : MonoBehaviour
{
    [SerializeField] Slider _slider;

    private float _recoveryRate = 10f;

    public IEnumerator ChangeHealthBar(float target)
    {
        while (_slider.value != target)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, target, _recoveryRate * Time.deltaTime);

            yield return null;
        }
    }
}
