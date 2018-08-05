using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    int score = -1;
    int bricks = 16;
    public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Счётчик очков
    public void IncrementScore() {
        score++;
        scoreText.text = "Счёт: " + score;
    }

    // Сброс счётчика очков
    public void ResetScore() {
        score = 0;
        scoreText.text = "Счёт: " + score;
    }

    // Счётчик кирпичиков
    public void BrickCount() {
        bricks--;
        if (bricks == 0) { SceneManager.LoadScene("LevelScene"); }
    }
}
