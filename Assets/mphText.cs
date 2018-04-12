using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class mphText : MonoBehaviour {
    public GameObject Car;
    public Rigidbody userCar; 
    public float speed;
    public int MPH;
    public Text MPHtext;
	// Update is called once per frame
    void Start ()
    {
        Car = GameObject.Find("Car");
        userCar = Car.GetComponent<Rigidbody>();
    }
	void Update () {
        speed = userCar.velocity.magnitude * 2.237f;
        MPH = (int) Math.Floor(speed);
        MPHtext.text = (MPH + " MPH");
	}
}
