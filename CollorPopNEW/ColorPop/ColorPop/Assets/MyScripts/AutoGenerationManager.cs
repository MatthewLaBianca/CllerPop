using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoGenerationManager : MonoBehaviour {

	public int firstNumber;
	public int secondNumber;
	public int thirdNumber;
	public int fourthNumber;
	public int fifthNumber;

	public Text first;
	public Text second;
	public Text third;
	public Text fourth;
	public Text fifth;
	

	public void GenerateNumbers(int highestAllowedGeneration)
	{
		firstNumber = Random.Range(1, highestAllowedGeneration);
		secondNumber = Random.Range(1, highestAllowedGeneration);
		thirdNumber = Random.Range(1, highestAllowedGeneration);
		fourthNumber = Random.Range(1, highestAllowedGeneration);
		fifthNumber = Random.Range(1, highestAllowedGeneration);

		first.text = firstNumber.ToString();
		second.text = secondNumber.ToString();
		third.text = thirdNumber.ToString();
		fourth.text = fourthNumber.ToString();
		fifth.text = fifthNumber.ToString();
		
	}

}
