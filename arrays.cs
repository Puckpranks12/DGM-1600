using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
    public Light[] lights:
    public int alarm = 0

void Start () 
{
	if (Input.GetKeyDown (KeyCode.a)) 					{alarm += 1;}
    for(int i = 0; 1 < light.Length; i++){
        lights [i].gameObject.SetActive (true);
        if (alarm >= 10){lights [i].color = color.red;}
    }
        
    }
}



public class Arrays : MonoBehaviour
{
    public GameObject[] gamers;

    void Start (){
        gamers = GameObject.FindGameObjectsWithTag("Player");
        
        for(int i = 0; i < gamers.Length; i++){
            Debug.Log(gamers[i].name+" is now leader of the wolf pack.";
        }
    }
}