using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public void StartGame() 
    {
        SceneManager.LoadScene("1");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
