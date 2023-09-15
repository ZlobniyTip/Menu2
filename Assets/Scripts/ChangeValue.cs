using UnityEngine;

public class ChangeValue : MonoBehaviour
{
    public int Heal { get; private set; }
    public int Damage { get; private set; }

    private void Start()
    {
        Heal = 10;
        Damage = 10;
    }
}
