using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject player;
    public GameObject speedText;

    private int speed;

	void Update ()
    {
        PlaneMovement planeStats = player.GetComponent<PlaneMovement>();
        speed = (int)Mathf.Floor(planeStats.speed) * 2;
        speedText.GetComponent<UnityEngine.UI.Text>().text = speed + " KM/H";
	}
}
