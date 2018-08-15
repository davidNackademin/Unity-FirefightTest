using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

    public GameManager gameManager;
    // verion 1 ingen collision detection 
    //  public List<Transform> positions = new List<Transform>();

    // version 2
    public List<GameObject> positions = new List<GameObject>();

    private float speed = 1f;
    private int currentPosition = 0;
    private float lastMoveTime;

	// Use this for initialization
	void Start () {
        lastMoveTime = Time.time;
        MoveToNextPosition();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > lastMoveTime + speed)
        {
            MoveToNextPosition();
            lastMoveTime = Time.time;
        }
	}

    void MoveToNextPosition()
    {
        currentPosition++;
        if (currentPosition >= positions.Count)
        {
            currentPosition = 0;
        }

        transform.position = positions[currentPosition].transform.position;

        if (!BounceCheck())
        {
            gameManager.Crash(this);
        }

    }

    bool BounceCheck()
    {

        JumperPosition position = GetCurrentJumperPosition();

        if (!position.dangerPosition )
            return true;
        
        return false;
    }

    public JumperPosition GetCurrentJumperPosition() {
        return positions[currentPosition].GetComponent<JumperPosition>();
    } 

}
