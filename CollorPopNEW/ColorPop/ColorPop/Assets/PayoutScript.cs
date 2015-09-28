using UnityEngine;
using System.Collections;

public class PayoutScript : MonoBehaviour {
    public GameObject payoutPanal;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TogglePayoutPanal()
    {
        if(!payoutPanal.activeSelf)
        {
            payoutPanal.SetActive(true);
        }
        else
        {
            payoutPanal.SetActive(false);
        }
    }


}
