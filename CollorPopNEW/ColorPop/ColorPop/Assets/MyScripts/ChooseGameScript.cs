using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ChooseGameScript : MonoBehaviour {

	[Serializable]
	public class Count
	{
		private int maximum;
		private int minimum;
		public Count(int min, int max)
		{
			maximum = max;
			minimum = min;
		}
		public int GetMin()
		{
			return minimum;
		}
		public int GetMax()
		{
			return maximum;
		}
	}

	public DartManager PopScript;
	public TicketManager TicketManager;

	//Dart Stuff
	public int amntOfDarts;

	public Button addDartsBttn;
	public Button subtractDartsBttn;
	public Button maxDarts;
	public Text amntDartsTxt;

	//Ticket Stuff
	private int amntOfTix;

	public Button addTixBttn;
	public Button subtractTixBttn;
	public Button maxTickets;
	public Text amntOfTixTxt;

	public Count darts = new Count(1,10);
	public Count tickets = new Count(1,5);

	// Use this for initialization
	void Start () {
		amntOfDarts = darts.GetMin();
		amntOfTix = 1;
	}
	
	// Update is called once per frame
	void Update () {
		DartStuff ();
		TicketStuff ();

	}
	public void SetAmountOfDarts()
	{
		PopScript.SetDarts (amntOfDarts);
	}
	public void SetAmountOfTix()
	{
		TicketManager.SetTix(amntOfTix);
		Debug.Log(TicketManager.GetTix());
	}
	//Dart Stuff
	private void DartStuff()
	{
		amntDartsTxt.text = amntOfDarts.ToString();
		if(amntOfDarts <= darts.GetMin()){
			subtractDartsBttn.interactable = false;
		}else{
			subtractDartsBttn.interactable = true;
		}
		if(amntOfDarts >= darts.GetMax()){
			addDartsBttn.interactable = false;
			maxDarts.interactable = false;

		}else{
			addDartsBttn.interactable = true;
			maxDarts.interactable = true;
		}
	}

	public void AddDarts()
	{
		amntOfDarts++;
	}
	public void SubtractDarts()
	{
		amntOfDarts--;
	}

	public void DartsMaxBet()
	{
		amntOfDarts = darts.GetMax ();
	}
	//End Dart Stuff

	//Ticket Stuff
	private void TicketStuff()
	{
		amntOfTixTxt.text = amntOfTix.ToString();
		if(amntOfTix <= tickets.GetMin()){
			subtractTixBttn.interactable = false;
		}else{
			subtractTixBttn.interactable = true;
		}
		if(amntOfTix >= tickets.GetMax()){
			addTixBttn.interactable = false;
			maxTickets.interactable = false;
		}else{
			addTixBttn.interactable = true;
			maxTickets.interactable = true;
		}
	}
	public void TixMaxBet()
	{
		amntOfTix = tickets.GetMax ();
	}
	public void AddTix()
	{
		amntOfTix++;
	}
	public void SubtractTix()
	{
		amntOfTix--;
	}
}
