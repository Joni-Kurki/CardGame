using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

	public enum Specials{ SMALL, BIG, HUGE, QUICK, HEAVYHITTER };

	public int index;
	public int color;
	public string name;
	public string description;
	public string arts;
	public Specials spes;
	public int attack, def;

	public Card(int index, int color, string name, string description){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
	}
	public Card(int index, int color, string name, string description, int attack, int def){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.attack = attack;
		this.def = def;
	}
	public Card(int index, int color, string name, string description, Specials spes){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.spes = spes;
	}
	public Card(int index, int color, string name, string description, int attack, int def, Specials spes){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.attack = attack;
		this.def = def;
		this.spes = spes;
	}

	public Card GetCard(){
		Debug.Log ("Returned ["+index+"] "+ name +" "+color+" "+description);
		return this;
	}
}
