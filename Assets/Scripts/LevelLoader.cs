using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;
    void Start () {
        //Geting scene that this object is in
        currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
        //If scene index is 0 wait with Coroutine, Load screen mock-up
        if (currentSceneIndex == 0) {
            StartCoroutine (WaitForTime ());
        }
    }
    IEnumerator WaitForTime () {
        yield return new WaitForSeconds (timeToWait);
        LoadNextScene ();

    }
    public void LoadNextScene () {
        //Load next scene in scene manager by adding 1 to its index
        SceneManager.LoadScene (currentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update () {

    }
}