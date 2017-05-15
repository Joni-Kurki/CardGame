using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

	public CardDatabase cdb;
	public GameObject cardDatabase;
	public GameObject playerHandArea;
	// Use this for initialization
	void Start () {
		cdb = cardDatabase.GetComponent<CardDatabase> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Card GetRandomCardFromDatabase(){
		int ran = Random.Range (0, cdb.cardList.Count);
		return cdb.cardList [ran];
	}
}
