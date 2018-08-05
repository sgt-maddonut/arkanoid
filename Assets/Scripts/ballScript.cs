using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballScript : MonoBehaviour {

    public Rigidbody2D rbBall;
    public UIManager scoreUI;
    public float ballForce;
    public bool gameStarted = true;

    // Use this for initialization
    void Start () {
        scoreUI = GameObject.FindWithTag("ScoreUI").GetComponent<UIManager>();
    }
	
	// Update is called once per frame
	void Update () {

        // Запуск шарика при нажатии на пробел
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false) {
            transform.SetParent(null);
            rbBall.isKinematic = false;
            rbBall.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
    }

    
    void OnCollisionEnter2D(Collision2D collision) {
        // Перезапуск уровня при соприкосновении шарика с полом
        if (collision.gameObject.tag == "Floor") {
            SceneManager.LoadScene("LevelScene");
        }

        if (collision.gameObject.tag == "Bat") {
            scoreUI.IncrementScore();
        }
    }
}
