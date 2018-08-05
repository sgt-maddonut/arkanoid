using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickScript : MonoBehaviour {

    public UIManager scoreUI;
    // Use this for initialization
    void Start () {
        scoreUI = GameObject.FindWithTag("ScoreUI").GetComponent<UIManager>();
	}
	
	// Update is called once per frame
	void Update () {
    }

    // Удаление кирпичика при коллизии с шариком
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Ball") {
            Destroy(gameObject);
            scoreUI.IncrementScore();
            scoreUI.BrickCount();
        }
    }
}
