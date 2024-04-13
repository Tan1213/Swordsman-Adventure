using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leve1Manager : MonoBehaviour
{
    public static Leve1Manager Instance = null;
    public Text tex;

    public int CoinCount = 0;

    public GameObject EndPanel;
    private void Awake()
    {
        Instance = this;

    }
    private void Update()
    {
        tex.text = "Gold£º" + CoinCount + "/11";

    }

    private void Start()
    {
        CoinCount = 0;
        EndPanel.SetActive(false);
    }


    public void NextGame() 
    {

        SceneManager.LoadScene("2");
    }
}
