using UnityEngine;
using System.Collections.Generic;

public class ThrowRandomDart : MonoBehaviour {


    public List<GameObject> drts = new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ThrowDart(int AmountOfDarts)
    {
        int rand = Random.Range(0, AmountOfDarts);
        drts[rand].SetActive(true);
    }
}
