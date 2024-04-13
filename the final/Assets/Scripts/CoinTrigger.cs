using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip Clip1, Clip2;
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayOneShot(Clip1);

            if (SceneManager.GetActiveScene().name.Equals("1"))
            {
                Leve1Manager.Instance.CoinCount += 1;
                if (Leve1Manager.Instance.CoinCount >= 11)
                {
                    AudioSource.PlayOneShot(Clip2);

                    Leve1Manager.Instance.EndPanel.SetActive(true);
                }
                Destroy(gameObject);
            }
            else if (SceneManager.GetActiveScene().name.Equals("2"))
            {
                Leve2Manager.Instance.CoinCount += 1;
                if (Leve2Manager.Instance.CoinCount >= 11)
                {
                    AudioSource.PlayOneShot(Clip2);

                    Leve2Manager.Instance.EndPanel.SetActive(true);
                }
                Destroy(gameObject);
            }
            else if (SceneManager.GetActiveScene().name.Equals("3"))
            {
                Leve3Manager.Instance.CoinCount += 1;
                if (Leve3Manager.Instance.CoinCount >= 11)
                {
                    AudioSource.PlayOneShot(Clip2);

                    Leve3Manager.Instance.EndPanel.SetActive(true);
                }
                Destroy(gameObject);
            }
        }
    }
}
