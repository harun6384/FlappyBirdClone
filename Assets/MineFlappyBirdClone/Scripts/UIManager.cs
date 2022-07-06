using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private GameObject gameOverUI;

    private void Start()
    {
        FindObjectOfType<CharacterMechanics>().OnPlayerDeath += onGameOver;
    }

    public void onGameOver()
    {
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }

    public void PauseUI()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
    }
    public void Continue()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene("MineFlappyBirdClone", LoadSceneMode.Single);
    }
}
