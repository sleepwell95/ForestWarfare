using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    [SerializeField] GameObject bullet, gun;
    public void Fire () {
        Instantiate (bullet, gun.transform.position, gun.transform.rotation);
    }
}