using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1Transition : MonoBehaviour
{
    public GameObject Home;
    public GameObject Options;
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OptionsMenu()
    {
        Options.gameObject.SetActive(true);
        Home.gameObject.SetActive(false);
    }

    public void OffMenu()
    {
        Options.gameObject.SetActive(false);
        Home.gameObject.SetActive(true);
    }
}