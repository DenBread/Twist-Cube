using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;


public class MovePlayer : MonoBehaviour {

	public float speed, speedAcceleration; // скорость 
	Rigidbody player;
	Vector3 offset;
	private const string achiv2 = "CgkIsNTHkKQdEAIQAw"; // ачивка
	//public bool test;

	private void Start() {
		player = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		Move();

	}

	void Move() // метод для выполение движений
	{
		if(Input.GetKey(KeyCode.A))
		{
			player.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Impulse);
		}

		if(Input.GetKey(KeyCode.D))
		{
			player.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Impulse);
		}

		offset = Input.acceleration;
		player.AddForce(offset.x * speedAcceleration * Time.deltaTime, 0f, offset.y * speedAcceleration * Time.deltaTime, ForceMode.Impulse);


        if(gameObject.transform.position.y < - 5) // Если игрок выпал за границы
        {
            gameObject.transform.position = new Vector3(0, 3f, 0);
			GetTheAchiv(achiv2);
        }
	}

	// Запуск ачивок
    private void GetTheAchiv(string id)
    {
        Social.ReportProgress(id, 100f, (bool success) =>
        {
            if (success) print("Получено достижение: " + id);
        });
    }

}
