using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject fireFighter;
    public GameObject jumper; 

	// Use this for initialization
	void Start () {
        Instantiate(jumper);
        jumper.GetComponentInChildren<Jumper>().gameManager = this;
	}
	
    public bool Crash(Jumper jumper) {

        if (jumper.GetCurrentJumperPosition() == )

        return false;
    }
}
