using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchMoveLeft : MonoBehaviour {

	public Rigidbody player;
	public float speed;
	public bool kek = true;


	private void OnMouseDrag() {
		if(Input.touchCount == 1)
        {
            Debug.Log("GoodLef");
            player.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Impulse);
        }
	}

	public void Test(bool test)
	{
		if(kek && test)
		{
			Debug.Log("GoodLef");
            player.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Impulse);
		}
	}
}
