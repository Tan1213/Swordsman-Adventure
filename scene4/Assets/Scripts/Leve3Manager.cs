using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leve3Manager : MonoBehaviour
{
    public static Leve3Manager Instance = null;
    public Text tex;

    public int CoinCount = 0;

    public GameObject EndPanel;
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        tex.text = "Gold��" + CoinCount + "/11";

    }

    private void Start()
    {
        CoinCount = 0;
        EndPanel.SetActive(false);
    }

    public void NextGame()
    {
        SceneManager.LoadScene("4");
    }
}
