using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFighter : MonoBehaviour {

    public GameManager gameManager;
    public List<Transform> positions = new List<Transform>();
    private int currentPosition;


    private void OnEnable()
    {
        Touch.OnLeft += Touch_OnLeft;
        Touch.OnRight += Touch_OnRight;
    }

    private void OnDisable()
    {
        Touch.OnLeft -= Touch_OnLeft;
        Touch.OnRight -= Touch_OnRight;
    }

    // Use this for initialization
    void Start () {
        currentPosition = positions.Count / 2;
        transform.position = positions[currentPosition].position;
    }
	
    private void Touch_OnRight()
    {
        if (currentPosition < positions.Count - 1)
        {
            currentPosition++;
            transform.position = positions[currentPosition].position;
        }
    }

    private void Touch_OnLeft()
    {
        if (currentPosition > 0)
        {
            currentPosition--;
            transform.position = positions[currentPosition].position;
        }
    }
}
