using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public List<Card> playerHand;
	GameControllerScript gcs;
	public int startingHandSize = 5;
	public GameObject gameController;

	// Use this for initialization
	void Start () {
		gcs = gameController.GetComponent<GameControllerScript> ();//new GameControllerScript();
		playerHand = new List<Card> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("f1"))
			DrawXCards (startingHandSize);
		if (Input.GetKeyDown ("f2"))
			GetCardInfo ();
	}

	void DrawXCards(int number=1){
		for (int i = 0; i < number; i++) {
			playerHand.Add(gcs.GetRandomCardFromDatabase ());
		}
		Debug.Log ("Player has " + playerHand.Count + " cards in hand");
	}
	void GetCardInfo(){
		string str = "";
		for (int i = 0; i < playerHand.Count; i++) {
			str += "[["+playerHand[i].index+"] " +playerHand [i].name + " ]\n";
		}
		Debug.Log (str);
	}
}
