using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int oldScore = 0;
    [SerializeField]
    private Text _MainText;
    string _ScoreWord = "Score: ";

    void Start() {
        _MainText.text = _ScoreWord + GameManager.score.ToString();
    }    void Update () {      
         if (GameManager.score != oldScore) {
            oldScore = GameManager.score;
            ChangeScore();
        }
    }

    private void ChangeScore() {
        _MainText.text = _ScoreWord + GameManager.score.ToString();
    }
}
