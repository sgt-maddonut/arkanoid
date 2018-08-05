using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class batScript : MonoBehaviour {

    public Rigidbody2D rbBat;
    public float batSpeed;
    public float maxX;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        // Движение биты
        float x = Input.GetAxis("Horizontal");
        if (x < 0) { MoveLeft(); }
        if (x > 0) { MoveRight(); }
        if (x == 0) { Stop(); }

        // Ограничение движения биты
        Vector3 batPosition = transform.position;
        batPosition.x = Mathf.Clamp(batPosition.x, -maxX, maxX);
        transform.position = batPosition;

        if (Input.GetKeyUp(KeyCode.Escape)) {
            SceneManager.LoadScene("LevelScene");
        }
    }

    // Движение биты влево
    void MoveLeft() {
        rbBat.velocity = new Vector2(-batSpeed, 0);
    }

    // Движение биты вправо
    void MoveRight() {
        rbBat.velocity = new Vector2(batSpeed, 0);
    }

    // Остановка биты
    void Stop() {
        rbBat.velocity = Vector2.zero;
    }
}
