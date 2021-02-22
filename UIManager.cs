using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : Singleton<UIManager>
{
    // Start is called before the first frame update
    public GameObject ignition;
    public GameObject rotateCrane;
    public GameObject rotateBoom;
    public GameObject extendPulley;
    public GameObject extendBoom;
    public GameObject pickUp;
    public GameObject dropBoom;
     public GameObject startCanvas;
     public GameObject pauseCanvas;
     public GameObject screenCanvas;

    public void Start()
    {
        ResetUI();
        Time.timeScale = 0f;
        startCanvas.SetActive(true);
    }

    public void ResetUI()
    {
        startCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        screenCanvas.SetActive(false);
    }

    public void StartGame()
    {
        ResetUI();
        screenCanvas.SetActive(true);
        Time.timeScale = 1f;
    }

    public void PauseGame(bool value)
    {
        screenCanvas.SetActive(!value);
        Time.timeScale = (value) ? 0f : 1f;
        pauseCanvas.SetActive(value);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void IgnitionDone()
    {
        ignition.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void RotateCraneDone()
    {
        rotateCrane.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void RotateBoomDone()
    {
        rotateBoom.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void ExtendPulleyDone()
    {
        extendPulley.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void ExtendBoomDone()
    {
        extendBoom.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void PickUpDone()
    {
        pickUp.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void DropBoomDone()
    {
        dropBoom.transform.GetChild(0).gameObject.SetActive(true);
    }

}
