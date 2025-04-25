using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealt;

    // Gibt zurück, ob Spieler noch Leben hat oder nicht
    private bool isAlive = true;


    private void Start()
    {
        currentHealt = maxHealth;

        UI_Manager.Instance.SetHpBar(currentHealt);
        //todo: Hier irgendwas machen
    }


    /// <summary>
    /// Getter für das Leben.
    /// </summary>
    /// <returns>Das aktuelle Leben</returns>
    public float GetCurrentHealth()
    {
        return currentHealt;
    }



    /// <summary>
    /// Setter für das Leben.
    /// </summary>
    /// <param name="_newHealth"></param>
    /// <returns>Das aktuelle Leben.</returns>
    public float SetCurrentHealth(float _newHealth)
    {
        currentHealt = _newHealth;
        return currentHealt;
    }


    /// <summary>
    /// Fügt dem Spieler Schaden zu.
    /// </summary>
    /// <param name="_damage">Höhe des Schadens.</param>
    /// <returns>Gibt das aktuelle Leben zurück.</returns>
    public float TakeDamage(float _damage)
    {
        if (isAlive)
        {
            currentHealt -= _damage;
            if (currentHealt <= 0)
            {
                currentHealt = 0;
                isAlive = false;
            }
        }

        UI_Manager.Instance.SetHpBar(currentHealt);

        return currentHealt;
    }

    /// <summary>
    /// Fügt dem Spieler Leben hinzu.
    /// </summary>
    /// <param name="_amount">Höhe des Lebens, das hinzugefügt werden soll.</param>
    /// <returns>Gibt das aktuelle Leben zurück.</returns>
    public float IncreaseHealth(float _amount)
    {
        currentHealt += _amount;
        if (currentHealt > maxHealth)
            currentHealt = maxHealth;

        UI_Manager.Instance.SetHpBar(currentHealt);

        return currentHealt;
    }
}
