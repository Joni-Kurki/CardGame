using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public List<Card> playerHand;
	public List<GameObject> playerHandPrefabs;
	List<Text> txtNames;
	List<Text> txtDescriptions;
	public GameControllerScript gcs;
	public int startingHandSize = 5;
	public GameObject gameController;
	public GameObject cardPrefab;
	public GameObject playerHandArea;

	// Use this for initialization
	void Start () {
		gcs = gameController.GetComponent<GameControllerScript> ();
		playerHand = new List<Card> ();
		playerHandPrefabs = new List<GameObject> ();
		txtNames = new List<Text> ();
		txtDescriptions = new List<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("f1")) {
			DrawCards ();
		}
		if (Input.GetKeyDown ("f2"))
			GetCardInfo ();
	}

	void DrawCards(){
		playerHand.Add(gcs.GetRandomCardFromDatabase ());
		Instantiate (cardPrefab, new Vector3 (0, 0, 0), Quaternion.identity, playerHandArea.transform);
		SetCardTexts ();
		SetCardArts ();
		Debug.Log ("Player has " + playerHand.Count + " cards in hand");
	}

	void SetCardTexts(){ // haetaan kaikki CardText tagilla olevat, laitetaan joka toinen eri listoihin ja niiden perusteella haetaan korttilistasta nimet ja selitykset
		GameObject[] goList = GameObject.FindGameObjectsWithTag ("CardText");
		txtNames = new List<Text> ();
		txtDescriptions = new List<Text> ();
		for (int i = 0; i < goList.Length; i++) {
			if (i % 2 == 0)
				txtNames.Add (goList [i].GetComponent<Text> ());
			if(i %2 == 1)
				txtDescriptions.Add(goList [i].GetComponent<Text> ());
		}
		for (int i = 0; i < playerHand.Count; i++) {
			txtNames [i].text = playerHand [i].name;
			txtDescriptions [i].text = playerHand [i].description;
		}
	}

	void SetCardArts(){
		GameObject[] goList = GameObject.FindGameObjectsWithTag ("CardArt");
		for (int i = 0; i < playerHand.Count; i++) {
			Image img = goList[i].GetComponent<Image>();
			img.sprite = playerHand [i].arts;
			//sRenderer.sprite = playerHand [i].arts;
		}
	}

	void GetCardInfo(){
		string str = "";
		for (int i = 0; i < playerHand.Count; i++) {
			str += "[["+playerHand[i].index+"] " +playerHand [i].name + " ]\n";
		}
		Debug.Log (str);
	}
}
