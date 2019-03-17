using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {
    [Header ("Stats")]

    float currentSpeed = 1f;

    void Start () {

    }

    void Update () {
        transform.Translate (Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed (float speed) {
        currentSpeed = speed;

    }

}