using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private UnityEvent _smoothChangeHealth;

    public void TakeDamage()
    {
        _smoothChangeHealth.Invoke();
    }

    public void TakeHeal()
    {
        _smoothChangeHealth.Invoke();
    }
}
