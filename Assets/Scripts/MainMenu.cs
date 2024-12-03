using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public enum MainMenuState {Open, Closed}
    [SerializeField] private MainMenuState menuState;

    private Transform[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        buttons = GetComponentsInChildren<Transform>();
        foreach (var button in buttons)
        {
            if(button.gameObject != gameObject)
            {
                button.gameObject.SetActive(false);
            }
        }

        menuState = MainMenuState.Closed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(menuState == MainMenuState.Open)
            {
                CloseMenu();
            }
            else
            {
                OpenMenu();
            }
        }
    }
    public void OpenMenu()
    {
        foreach (var button in buttons)
        {
            if (button.gameObject != gameObject)
            {
                button.gameObject.SetActive(true);
            }
        }

        menuState = MainMenuState.Open;
        Time.timeScale = 0;
    }

    public void CloseMenu()
    {
        foreach (var button in buttons)
        {
            if (button.gameObject != gameObject)
            {
                button.gameObject.SetActive(false);
            }
        }

        menuState = MainMenuState.Closed;
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}