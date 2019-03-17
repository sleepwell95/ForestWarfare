using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [Header ("Projectile Stats")]
    [SerializeField] float shootSpeed = 220f; //Speed that projectile moves at in deltatime
    [SerializeField] int speedOfSpin = 360; //Spining per secound
    [SerializeField] float projectileDamage = 50f; //Damage of this particular projectile(can be modified in inspector)

    void Update () {
        Shoot (); //Moving in Update 
    }
    public void Shoot () {

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (shootSpeed * Time.deltaTime, 0); //Get RigidBody and give it a new velocity
        transform.Rotate (0, 0, speedOfSpin * Time.deltaTime); //Spin object on Z axis
    }

    private void OnTriggerEnter2D (Collider2D otherCollider) { //If collision happened 

        var health = otherCollider.GetComponent<Health> (); //only works if component got Health script on it
        var attacker = otherCollider.GetComponent<Attacker> (); //only works if component got Attacker script on it
        if (attacker && health) {
            //Checking if both is there

            health.DealDamage (projectileDamage); //Do damage with projectileDamage variable 
            Destroy (gameObject); //On Collision Destroy projectile

        }
    }
}