using UnityEngine;
using System.Collections.Generic;

public class ThrowRandomDart : MonoBehaviour {

    public GameObject Jackpot;
    public GameObject twoTimes;
    public GameObject oneThousand;
    public GameObject tapTxt;
    public GameObject flare;
    public List<GameObject> drts = new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void ThrowDart()
    {
        int rand = Random.Range(0, drts.Capacity);
        drts[rand].SetActive(true);
        if(rand == 0)
        {
            Jackpot.SetActive(true);
            oneThousand.SetActive(true);
            tapTxt.SetActive(false);
            flare.SetActive(true);

        }
        else
        {
            twoTimes.SetActive(true);
            tapTxt.SetActive(false);
        }
    }
}
