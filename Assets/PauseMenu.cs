using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject wristUI;
    public bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        DisplayWristUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPauseButtonPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            DisplayWristUI();
        }
    }

    public void DisplayWristUI()
    {
        if (isActive)
        {
            Resume();
        }
        else if (!isActive)
        {
            wristUI.SetActive(true); 
            isActive = true;
            Time.timeScale = 0f;
        }
    }

    public void Resume()
    {
        wristUI.SetActive(false);
        isActive = false;
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Debug.Log("QUIT THE GAME.");
        Application.Quit();
    }
}
