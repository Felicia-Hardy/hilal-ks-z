using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

void Start()
{
    //Debug.Log("Menu scene Opened");
}

public void PlayButton()
{

    Debug.Log("Play button pressed.");
    SceneManager.LoadScene("PlayScene");
}
}
