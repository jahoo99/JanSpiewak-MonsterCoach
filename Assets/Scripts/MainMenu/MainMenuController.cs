using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject _optionPanel;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OptionsOn()
    {
        _optionPanel.SetActive(true);
    }
    public void OptionsOff()
    {
        _optionPanel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsOff();
        }
    }
}
