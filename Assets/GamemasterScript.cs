using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamemasterScript : MonoBehaviour
{
    //Variables about the turns
    bool DealersTurn;
    //Revolver Variables
    public bool[] Magazine = new bool[6];
    public int ActiveChamber = 0;
    public int Damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        Reload();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Reload()
    {
        for(int i = 0; i < 6; i++)
        {
            if(Random.Range(0f, 1f) >= 0.5)
            {
                Magazine[i] = true;
            }
            else
            {
                Magazine[i] = false;
            }
        }
        Debug.Log("Reloaded");
        ActiveChamber = 0;
    }
    public void Fire(GameObject Target)
    {
        if(Magazine[ActiveChamber] == true)
        {
            Debug.Log(Target + " Was Shot Dead");
            var TargetHealth = Target.GetComponent<HealthScript>();
            TargetHealth.TakeDamage(Damage);
        }
        else
        {
            Debug.Log("It was a blank");
        }
        Damage = 1;
        ActiveChamber += 1;
        DealersTurn = !DealersTurn;
    }
}
