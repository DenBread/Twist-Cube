using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchMoveRight : MonoBehaviour {

	public Rigidbody player;
	public float speed;

	private void OnMouseDrag() {
		if(Input.touchCount == 1)
        {
            Debug.Log("GoodLef");
            player.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Impulse);
        }
	}
}
