using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBufferItem : MonoBehaviour
{
    GamemasterScript MasterScript;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        MasterScript = GameObject.Find("THE HOUSE").GetComponent<GamemasterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuffDamage()
    {
        MasterScript.Damage *= 2;
        Button.SetActive(false);
    }
}
