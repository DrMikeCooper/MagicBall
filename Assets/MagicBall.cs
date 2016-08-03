using UnityEngine;
using System.Collections;

public class MagicBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Dr Mike's branch
    void MakeEverythingShiny(float alpha)
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


    void ConflictA()
    {
    }

void ConflictB()
{
}

}
