using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public List<Card> playerHand;
	public List<Card> cardsInPlay;
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
		cardsInPlay = new List<Card> ();
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

	void DrawCards(){ // nostetaan kortti, instansioidaan se, sen kortin tiedoilla.
		Card c = gcs.GetRandomCardFromDatabase ();
		playerHand.Add(c);
		GameObject go = Instantiate (cardPrefab, new Vector3 (0, 0, 0), Quaternion.identity, playerHandArea.transform);
		//CardModelScript cms = go.GetComponent<CardModelScript> ();
		//cms.name = playerHand [playerHand.Count - 1].name;
		//cms.description = playerHand [playerHand.Count - 1].description;
		SetCardModel (go, c.name, c.description, c.arts, c.attack, c.def);
		//Debug.Log ("Player has " + playerHand.Count + " cards in hand");
	}

	void SetCardModel(GameObject obj, string name, string desc, Sprite img, int att, int def){
		Image image = obj.transform.GetChild (0).GetComponent<Image>();
		image.sprite = img;
		Text title = obj.transform.GetChild (1).GetComponent<Text>();
		if (att != 0 && def != 0)
			title.text = name + " [" + att + "/" + def + "]";
		else
			title.text = name;
		Text description = obj.transform.GetChild (2).GetComponent<Text>();
		description.text = desc;
	}

	void GetCardInfo(){
		string str = "";
		for (int i = 0; i < playerHand.Count; i++) {
			str += "[["+playerHand[i].index+"] " +playerHand [i].name + " ]\n";
		}
		Debug.Log (str);
	}
}
