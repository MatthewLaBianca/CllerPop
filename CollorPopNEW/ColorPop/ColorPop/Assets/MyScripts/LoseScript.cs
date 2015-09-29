using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour {

    public Text matches;
    public NumberManager numMan;
    public DartManager dartMan;

    public Text winOrLose;

    public Text winnings;


    public Text tic1;
    public Text tic2;
    public Text tic3;
    public Text tic4;
    public Text tic5;


    public class WinningStuff
    {
        private int numOfDarts;
        private int actualPrize;
        private string winLoseStrng;
        private Color winLoseColor;
        private string winString = "WINNER!";
        private string loseString = "Loser";
        public WinningStuff()
        {
            winLoseColor = Color.green;
        }
        public void SetDarts(int drts)
        {
            numOfDarts = drts;
        }

        public Color GetColor()
        {
            return winLoseColor;
        }

        public string GetWinLoseString()
        {
            return winLoseStrng;
        }
        public int GetWinnings(int matches)
        {
            

            switch (numOfDarts)
            {
                case 3:
                    if (matches == 0)
                    {
                        actualPrize = 0;
                        winLoseStrng = loseString;
                        winLoseColor = Color.red;
                    }
                    if (matches == 1)
                    {
                        actualPrize = 0;
                        winLoseStrng = loseString;
                        winLoseColor = Color.red;
                    }
                    if (matches == 2)
                    {
                        actualPrize = 1;
                        winLoseStrng = winString;
                    }
                    if(matches == 3)
                    {
                        actualPrize = 5;
                        winLoseStrng = winString;
                    }
                    break;
                case 4:
                    if (matches == 0)
                    {
                        actualPrize = 0;
                        winLoseStrng = loseString;
                        winLoseColor = Color.red;
                    }
                    else if (matches == 1)
                    {
                        actualPrize = 0;
                        winLoseStrng = loseString;
                        winLoseColor = Color.red;
                    }
                    else if (matches == 2)
                    {
                        actualPrize = 1;
                        winLoseStrng = winString;
                    }
                    else if (matches == 3)
                    {
                        actualPrize = 2;
                        winLoseStrng = winString;
                    }
                    else if (matches == 4)
                    {
                        actualPrize = 25;
                        winLoseStrng = winString;
                    }
                    break;
                case 5:
                    if (matches == 0)
                    {
                        actualPrize = 0;
                        winLoseStrng = loseString;
                        winLoseColor = Color.red;
                    }
                    else if (matches == 1)
                    {
                        actualPrize = 1;
                        winLoseStrng = winString;
                    }
                    else if (matches == 2)
                    {
                        actualPrize = 2;
                        winLoseStrng = winString;
                    }
                    else if (matches == 3)
                    {
                        actualPrize = 10;
                        winLoseStrng = winString;
                    }
                    else if (matches == 4)
                    {
                        actualPrize = 20;
                        winLoseStrng = winString;
                    }
                    else if (matches == 5)
                    {
                        actualPrize = 50;
                        winLoseStrng = winString;
                    }
                    break;

            }
            return actualPrize;
        }

    }

    WinningStuff winningstuff = new WinningStuff();

    // Use this for initialization
    void Start () {
        dartMan = GameObject.Find("ScriptHolder").GetComponent<DartManager>();
        
	}
	
	// Update is called once per frame
	void Update () {
        winningstuff.SetDarts(dartMan.GetInitDarts());
        matches.text = numMan.GetNumbersMatched().ToString();
        winnings.text = "$" + winningstuff.GetWinnings(numMan.GetNumbersMatched()).ToString();
        winOrLose.color = winningstuff.GetColor();
        winOrLose.text = winningstuff.GetWinLoseString();
	}



    //This is when you hit replay
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
