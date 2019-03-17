using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    [SerializeField] GameObject defender; //Assigning any prefab
    private void OnMouseDown () { //Works on mouse click
        SpawnDefender (GetSquareClicked ());

    }
    private Vector2 GetSquareClicked () {
        Vector2 clickpos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y); //Geting mouse position
        Vector2 worldpos = Camera.main.ScreenToWorldPoint (clickpos);
        Vector2 gridPos = SnapToGrid (worldpos);
        return gridPos;
    }
    private Vector2 SnapToGrid (Vector2 rawWorldPos) { //Creating new position with vector2

        float newX = Mathf.RoundToInt (rawWorldPos.x); //Rounding that position with Mathf
        float newY = Mathf.RoundToInt (rawWorldPos.y);
        return new Vector2 (newX, newY); //Returning it by new vector
    }
    private void SpawnDefender (Vector2 roundedPos) {
        GameObject newDefender = Instantiate (defender, roundedPos, Quaternion.identity) as GameObject;
    }
}