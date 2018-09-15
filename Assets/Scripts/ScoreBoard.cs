using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    int score;
    Text scoreText;

	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<Text>();
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString().PadLeft(8, '0');
    }

    public void ScoreHit (int hitScore) {
        if (hitScore < 0)
            return;
        score += hitScore;
        UpdateScoreText();
    }
}
