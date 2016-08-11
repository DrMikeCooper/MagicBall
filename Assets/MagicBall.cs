using UnityEngine;
using System.Collections;

public class MagicBall : MonoBehaviour {

    //Player 1 code
	bool isUserA;
	bool isUserB;

	// Use this for initialization
	void Start () {
        bool userA = true;
		if (userA)
			Debug.Log("I am the Greatest!");
	}

	// Update is called once per frame
	void Update () {
        bool UserBChange = true;
		if (UserBChange)
			return;
    }
}
