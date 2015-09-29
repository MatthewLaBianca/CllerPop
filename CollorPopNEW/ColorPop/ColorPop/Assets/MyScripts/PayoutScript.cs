﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PayoutScript : MonoBehaviour {
    public GameObject payoutPanal;
    public Text newNums;
    public Text oldNums;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TogglePayoutPanal(GameObject objToToggle)
    {
        if(!objToToggle.activeSelf)
        {
            objToToggle.SetActive(true);
        }
        else
        {
            objToToggle.SetActive(false);
        }
    }

    public void TogglePayoutPanalWithText(GameObject objToToggle)
    {
        //oldNums.text = GameObject.Find("TextTic" + ticNum.ToString()).GetComponent<Text>().text;
        if (!objToToggle.activeSelf)
        {
            newNums.text = oldNums.text.ToString();
            objToToggle.SetActive(true);
        }
        else
        {
            objToToggle.SetActive(false);
        }
    }



}
