using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] public TMP_Text _scoreText, _scoreTextPauseUI, _scoreTextEndUI;
    public int score = 0;
    private void Start()
    {
        FindObjectOfType<CharacterMechanics>().OnPlayerScore += onPlayerScore;
    }

    private void onPlayerScore()
    {
        score += 1;
        var finScore = score / 4;
        _scoreText.text = finScore.ToString();
        _scoreTextPauseUI.text = finScore.ToString();
        _scoreTextEndUI.text = finScore.ToString();
    }
}
