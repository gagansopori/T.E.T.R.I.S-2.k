using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScriptController : MonoBehaviour {

    [SerializeField]
    private GameObject[] tetrisObjects;


    
    // Use this for initialization
	void Start () {
        SpawnRandom();
	}
	
	
    public void SpawnRandom()
    {
        int index = Random.Range(0, tetrisObjects.Length);
        Instantiate(tetrisObjects[index], transform.position, Quaternion.identity);
    }
}
