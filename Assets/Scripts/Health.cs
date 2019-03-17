using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] float health = 100f; //Setting health to an attacker
    [SerializeField] GameObject deathVFX;

    //Function requires damage to be  passed "float damage"
    public void DealDamage (float damage) {
        health -= damage; //Enemy health - damage
        if (health <= 0) { //If health is less or = 0 
            TriggerDeathVFX ();
            Destroy (gameObject); //Destroy gameObject
        }
    }
    private void TriggerDeathVFX () {
        if (!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate (deathVFX, transform.position, Quaternion.identity);
        Destroy (deathVFXObject, 1f);
    }

}