using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour {

    public Text matches;
    public NumberManager numMan;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        matches.text = numMan.GetNumbersMatched().ToString();
	}
}
