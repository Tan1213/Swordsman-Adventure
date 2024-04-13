using UnityEngine;
using UnityEngine.SceneManagement;
public class Leve4Manager : MonoBehaviour
{
    public static Leve4Manager Instance = null;


    public GameObject EndPanel;

    public GameObject m_ChestClose;
    public GameObject m_ChestOpen;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        EndPanel.SetActive(false);
        m_ChestClose.SetActive(true);
        m_ChestOpen.SetActive(false);
    }

    public void NextGame()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver() 
    {
        EndPanel.SetActive(true);
        m_ChestClose.SetActive(false);
        m_ChestOpen.SetActive(true);
    }
}
