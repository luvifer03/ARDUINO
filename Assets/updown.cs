using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class updown : MonoBehaviour {
	SerialPort sp = new SerialPort ("\\\\.\\COM11", 9600);
	// Use this for initialization
	void Start () {
		sp.Open();
		sp.ReadTimeout = 45;
	}

	void Update () {
		if (sp.IsOpen) {
			try {
				if (sp.ReadByte() == 1) {
					transform.Translate(Vector3.down * Time.deltaTime * 5);
				}
				if (sp.ReadByte() == 2) {
					transform.Translate(Vector3.up * Time.deltaTime * 5);
				}
			} catch (System.Exception) {
			}
		}
	}
}