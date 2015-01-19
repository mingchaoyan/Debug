using UnityEngine;
using System.Collections;

public class Count : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		int sum = 0;
		if (GUILayout.Button ("Count")) {
			for(int i = 0; i < 5; ++i) {
				sum += i;
				print (sum);
			}
				
		}
	}
}
