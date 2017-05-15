using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

	public enum Specials{ SMALL, BIG, HUGE, QUICK, HEAVYHITTER };

	public int index;
	public int color;
	public string name;
	public string description;
	public Sprite arts;
	public Specials spes;
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
	public Card(int index, int color, string name, string description, Specials spes, Sprite sprite){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.spes = spes;
		this.arts = sprite;
	}
	public Card(int index, int color, string name, string description, int attack, int def, Specials spes, Sprite sprite){
		this.name = name;
		this.index = index;
		this.name = name;
		this.description = description;
		this.attack = attack;
		this.def = def;
		this.spes = spes;
		this.arts = sprite;
	}

	public Card GetCard(){
		Debug.Log ("Returned ["+index+"] "+ name +" "+color+" "+description);
		return this;
	}
}
