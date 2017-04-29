using UnityEngine;
using System.Collections;

public class SwitchesScript : MonoBehaviour {

	public int value;

	public enum States {controller, wii, game, loz, mac};
	public States game;

	private States save;


	// Use this for initialization
	void Start () {
		save = game;

		switch (game) {
		case States.controller:
			print ("controllers...");
			break;
		case States.wii:
			print ("WiiU");
			break;
		case States.game:
			print ("videogames");
			break;
		case States.loz:
			print ("Legend of Zelda: Breath of the Wild hyyyyyype");
			break;
		case States.mac:
			print ("Macs are the worst things ever");
			break;

		}
	}
	
	// Update is called once per frame
	void Update () {
		if (save != game){
			Start ();
	}
}



public enum States {Walmart, Target, Kmart, Biglots, Michaels};
public States stores;

private States save;


// Use this for initialization
void Start () {
	save = stores;

	switch (game) {
	case States.Walmart:
		print ("trash bin");
		break;
	case States.Target:
		print ("red room of death");
		break;
	case States.Kmart:
		print ("christmas commercials");
		break;
	case States.Biglots:
		print ("that still exists?");
		break;
	case States.Michaels:
		print ("CRAFTS");
		break;

	}
}

	// Update is called once per frame
	void Update () {
		if (save != stores){
			Start ();
		}
	}
}