using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{

    public GameObject losePanel;
    private void Start()
    {
        Time.timeScale = 1;
        losePanel.SetActive(false);
    }

    private void Update()
    {
        
    }

    public void LosePanel()
    {
        Time.timeScale = 0;
        losePanel.SetActive(true);
    }

    public void RestartLevel()
    {
        int sceneBuildIndex = SceneManager.GetActiveScene().buildIndex; ;
        SceneManager.LoadScene(sceneBuildIndex);
    }             
}
