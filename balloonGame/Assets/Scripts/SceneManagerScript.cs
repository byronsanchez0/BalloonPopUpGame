using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene(0);
    }
    public void goToMenu()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
