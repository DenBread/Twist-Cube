using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCoin : MonoBehaviour {

	private void LateUpdate() {
		if(Input.GetKey(KeyCode.C))
		{
			PlayerPrefs.DeleteAll();
		}
	}
}
