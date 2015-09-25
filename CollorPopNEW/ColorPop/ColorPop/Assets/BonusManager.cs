using UnityEngine;
using System.Collections;

public class BonusManager : MonoBehaviour {

    public bool startBonusGame;
    public GameObject leftSideCanvas;
    public GameObject timerandnumbers;

    public GameObject chestone;
    public GameObject chesttwo;
    public GameObject chestthree;

    public Transform placementOne;
    public Transform placementTwo;
    public Transform placementThree;


    private float smoothness = 0.02f;
    private float duration = 1.0f;

    public GameObject bonusCanvas;
	// Use this for initialization
	void Start () {
        startBonusGame = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if(startBonusGame)
        {
            bonusCanvas.SetActive(true);
            StartCoroutine(MoveObject(chestone, placementOne));
            leftSideCanvas.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
            timerandnumbers.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
            //leftSideCanvas.SetActive(false);
            //timerandnumbers.SetActive(false);
        }
	}

    IEnumerator MoveObject(GameObject objFrom, Transform objTo)
    {
        float progress = 0;
        float increment = smoothness / duration;
        yield return new WaitForSeconds(.4f);
        while (progress < 1)
        {
            objFrom.transform.position = Vector3.Lerp(objFrom.transform.position, objTo.transform.position, progress);
            progress += increment;
            yield return new WaitForSeconds(smoothness);
        }


        yield return 0;
    }
}
