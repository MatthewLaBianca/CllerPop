using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour {

    public Text matches;
    public NumberManager numMan;
    public DartManager dartMan;


    public Text tic1;
    public Text tic2;
    public Text tic3;
    public Text tic4;
    public Text tic5;


    // Use this for initialization
    void Start () {
        dartMan = GameObject.Find("ScriptHolder").GetComponent<DartManager>();
	}
	
	// Update is called once per frame
	void Update () {
        matches.text = numMan.GetNumbersMatched().ToString();
	}

    public void Replay()
    {
        //What happens when the replay button is pressed
        numMan.OutOfDarts = false;
        numMan.OutOfTix = false;
        tic1.text = "";
        tic2.text = "";
        tic3.text = "";
        tic4.text = "";
        tic5.text = "";
        numMan.numbersMatched = 0;
        //numMan.ResetText();
        if (!numMan.OutOfTix && !numMan.OutOfTix)
        {
            dartMan.ReplayDarts();
            numMan.i = 0;
            numMan.numbers.Clear();
            numMan.ticketNumber = 1;
            gameObject.SetActive(false);
        }
        
        //
    }



}
