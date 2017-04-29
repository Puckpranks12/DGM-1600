int health = 100;
bool musicPlayer;
bool respawnIcon;
bool danceCreator;
string words;

void Update(){
		if(health <= 0)
			Death();
		if(musicPlayer)
			Music();
		if(respawnIcon)
			Revive();
		if(danceCreator)
			Dance();
}


void Death(){
	words = "You died. Hit x to Respawn";
	this.gameObject.Destroy();
}

void Music(){
	//plays music
}

void Revive(){
	//revives you
}

void Dance(){
	//makes you start DANCING
}

if(health > 0 && musicPlayer)
	//makes everyone else party

	
if(musicPlayer || danceCreator)
	//have fun dawg
