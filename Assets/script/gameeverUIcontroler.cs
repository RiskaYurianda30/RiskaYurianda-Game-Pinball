using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameeverUIcontroler : MonoBehaviour
{
    public Button mainMenuButton;
    private object mainMenu;

    private void Start()
    {
        mainMenuButton.onClick.AddListener((UnityEngine.Events.UnityAction)mainMenu);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
