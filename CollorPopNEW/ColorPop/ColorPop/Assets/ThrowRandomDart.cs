using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ThrowRandomDart : MonoBehaviour {

    public GameObject Jackpot;
    public GameObject twoTimes;
    public GameObject oneThousand;
    public GameObject tapTxt;
    public GameObject flare;
    public Text balance;
    public List<GameObject> drts = new List<GameObject>();

    public Button throwDrtBttn;

    public BonusManager bonusMan;
    public BalloonPop ballonPopMan;
   
    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        if (bonusMan.startBonusGame)
        {
            TimerBeforeThrowable(4.0f);
        }
	}
    IEnumerator TimerBeforeThrowable(float timeToWait)
    {
        throwDrtBttn.interactable = false;
        yield return new WaitForSeconds(timeToWait);
        throwDrtBttn.interactable = true;
        yield return 0;
    }
    IEnumerator ReturnToGame(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        bonusMan.startBonusGame = false;
        yield return 0;
    }

    public void ThrowDart()
    {
        int rand = Random.Range(0, drts.Capacity);
        drts[rand].SetActive(true);
        throwDrtBttn.interactable = false;
        if(rand == 0)
        {
            Jackpot.SetActive(true);
            oneThousand.SetActive(true);
            tapTxt.SetActive(false);
            flare.SetActive(true);
            balance.text = "$1130";
            StartCoroutine(ReturnToGame(4.3f));
            ballonPopMan.maxNum = 40;
        }
        else
        {
            twoTimes.SetActive(true);
            tapTxt.SetActive(false);
            StartCoroutine(ReturnToGame(.8f));
            ballonPopMan.maxNum = 40;
        }
        

    }
}
