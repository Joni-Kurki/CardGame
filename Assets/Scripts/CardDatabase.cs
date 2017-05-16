using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour {

	public List<Card> cardList;
	public Sprite[] artsToUse;

	// Use this for initialization
	void Awake () {
		cardList = new List<Card> ();
		CreateDatabase ();
		Debug.Log ("Init complete. Added "+cardList.Count+ " cards.");
	}

	// tänne kaikki maholliset kortit sitten.
	void CreateDatabase(){
		Card c = new Card (0,0,"Peasant","A simple farmer",1,1, Card.CardType.MONSTER, artsToUse[0]);
		cardList.Add(c);
		c = new Card (1, 0, "Foreman", "Farmers boss", 2,2, Card.CardType.MONSTER,artsToUse[1]);
		cardList.Add(c);
		c = new Card (2, 0, "Horse ride", "With horse, you can go faster", Card.CardType.SPELL, artsToUse[2]);
		cardList.Add(c);
		c = new Card (3, 0, "Plow", "Helps build stuff faster",Card.CardType.SPELL, artsToUse[3]);
		cardList.Add(c);
		c = new Card (4, 0, "Farmhouse", "House gives shelter", Card.CardType.BUILDING, artsToUse[4]);
		cardList.Add(c);
		c = new Card (5, 1, "Orc", "Smelly orc",1,2, Card.CardType.MONSTER, artsToUse[5]);
		cardList.Add(c);
		c = new Card (6, 1, "Imp", "Impish",2,1, Card.CardType.MONSTER, artsToUse[6]);
		cardList.Add(c);
		c = new Card (7, 1, "Orc spearman", "A smelly orc with sharp stick",1,3, Card.CardType.MONSTER, artsToUse[7]);
		cardList.Add(c);
		c = new Card (8, 1, "Ogre", "One heck of ugly beastman",5,2, Card.CardType.MONSTER, artsToUse[8]);
		cardList.Add(c);
	}
}