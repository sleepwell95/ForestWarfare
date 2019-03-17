using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    bool spawn = true;
    [SerializeField] Attacker attackerPrefab;

    // Start is called before the first frame update
    IEnumerator Start () {
        while (spawn) {
            yield return new WaitForSeconds (Random.Range (minSpawnDelay, maxSpawnDelay));
            Spawner ();

        }
    }
    private void Spawner () {
        Instantiate (attackerPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update () {

    }
}