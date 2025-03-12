using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] TMP_Text scoreDisplayText;
    [SerializeField] TMP_Text highScoreDisplayText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreDisplay();
        HighScoreDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ScoreDisplay()
    {
        scoreDisplayText.text = "Your Score : "+Snake.score;
    }
    private void HighScoreDisplay()
    {
        highScoreDisplayText.text = "High Score : " + PlayerPrefs.GetInt("highScore").ToString();
    }

    public void TryAgain()
    {

        SceneManager.LoadScene(1);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);  
    }
}
