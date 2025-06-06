using UnityEngine;

[RequireComponent(typeof(IDefenseHandler))]
[RequireComponent(typeof(DamageHandler))]
public class BaseDamageReceiver : MonoBehaviour
{
    protected IDefenseHandler defenseHandler;
    private DamageHandler damageHandler;

    private void Awake()
    {
        damageHandler = GetComponent<DamageHandler>();
        if (damageHandler == null)
        {
            Debug.LogError($"No DamageHandler found on {gameObject.name}");
        }
    }

    public void ReceiveDamage(DamageData damageData)
    {
        if (damageHandler == null)
        {
            Debug.LogError($"Cannot receive damage on {gameObject.name} - DamageHandler is null");
            return;
        }
        damageHandler.HandleDamage(damageData);
    }
}
