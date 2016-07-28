using UnityEngine;
using System.Collections;

public class MagicBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void MainComputer()
    {
    }

	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.A))
            pos.x -= 0.1f;
        if (Input.GetKey(KeyCode.D))
            pos.x += 0.1f;
        transform.position = pos;
        if (Input.GetKeyDown(KeyCode.W))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 500, 0));
    }

void FunctionB()
{
}

<<<<<<< HEAD
    void ConflictA()
    {
    }
=======
void ConflictB()
{
}
>>>>>>> f0d83716a9433263e9e62aca8e3ba1f0dad50c1f
}
