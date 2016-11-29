using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWanger : MonoBehaviour {

	public Text leftText;
	public Text rightText;
	public Text playerText;
	public Text computerText;
	int playerScore;
	int computerScore;
	
	System.Random getrandom = new System.Random();
	
	int rangeLow = -100;
	int rangeHigh = 100;
	
	
	// Use this for initialization
	void Start () {
		playerScore = 0;
		computerScore = 0;
		
		leftText.text = "" + 0;
	
		RefreshOptions();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void LeftButtonClicked() { 
		isNumberWang();
		RefreshOptions();
	}
	public void RightButtonClicked() { 
		isNumberWang();
		RefreshOptions();
	}
	
	void isNumberWang() {
		if (getrandom.Next(0, 100) > 70)
		{
			Debug.Log("ThatsNumberWang");
			++playerScore;
		}
		else {
			++computerScore;
		}	
		SetScoreText();
	}
	
	void RefreshOptions() {
		if (getrandom.Next(0, 100) > 20) {
			leftText.text = "" + getrandom.Next(rangeLow, rangeHigh);
		}
		if (getrandom.Next(0, 100) > 20) {
		rightText.text = "" + getrandom.Next(rangeLow, rangeHigh);
		}
		while ( leftText.text == rightText.text ) 
			rightText.text = "" + getrandom.Next(rangeLow, rangeHigh);
	}
	
	void SetScoreText() {
		playerText.text = "You " + playerScore;
		computerText.text = computerScore + " Computer";
		
	}
}
