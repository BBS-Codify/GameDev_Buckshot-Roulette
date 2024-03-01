using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int MaxHealth, CurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentHealth <= 0)
        {
            Debug.Log(gameObject + "'S DEADDDDD");
            CurrentHealth += 1;
        }
    }
    
    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
    }
}
