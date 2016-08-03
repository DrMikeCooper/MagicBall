using UnityEngine;
using System.Collections;

public class MagicBall : MonoBehaviour {

    //Player 1 code

	// Use this for initialization
	void Start () {
	
	}

    void AddNavigation()
    {
        doNav();
    }

    // Dr Mike's branch
    void MakeEverythingShiny(float alpha)
    {
    }

    void MakeObjectShiny(GameObject obj)
    {
    }


    //Player 2 Code

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
    void NormalCode()
    {
        for (int i = 0; i < 10; i++)
            Debug.Log(i);
    }

}
