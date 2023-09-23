using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _text;

    public void ShowHealth(float value)
    {
        _text.text = _slider.value.ToString();
    }
}
