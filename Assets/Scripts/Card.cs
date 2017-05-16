using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

	public enum CardType{ MONSTER,SPELL,BUILDING };

	public int index;
	public int color;
	public string name;
	public string description;
	public Sprite arts;
	public CardType cardtype;
	public int attack, def;

	public Card(int index, int color, string name, string description, Sprite sprite){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.arts = sprite;
	}
	public Card(int index, int color, string name, string description, int attack, int def, Sprite sprite){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.attack = attack;
		this.def = def;
		this.arts = sprite;
	}
	public Card(int index, int color, string name, string description, CardType cardtype, Sprite sprite){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.cardtype = cardtype;
		this.arts = sprite;
	}
	public Card(int index, int color, string name, string description, int attack, int def, CardType cardtype, Sprite sprite){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.attack = attack;
		this.def = def;
		this.cardtype = cardtype;
		this.arts = sprite;
	}

	public Card GetCard(){
		Debug.Log ("Returned ["+index+"] "+ name +" "+color+" "+description);
		return this;
	}
}
