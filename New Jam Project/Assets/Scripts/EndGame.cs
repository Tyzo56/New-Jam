using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject LosePanel;
    [SerializeField] private Text EndMessage;


    public void Win()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void Lose(string loseMessage)
    {
        LosePanel.SetActive(true);
        EndMessage.text = loseMessage;
    }
}
