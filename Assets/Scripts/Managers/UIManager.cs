using System.Collections;
using UnityEngine.UI;
using UnityEngine;

// Sam Robichaud 
// NSCC Truro 2022

public class UIManager : MonoBehaviour
{
    //Script references
    public GameObject ball;
    private BallManager _ballController;

    //private GameObject gameManager;
    public GameManager _gameManager;

    public GameObject gamePlayUI;
    public GameObject mainMenuUI;
    public GameObject levelSelectUI;
    public GameObject levelCompleteUI;
    public GameObject gameCompleteUI;
    public GameObject levelFailedUI;
    public GameObject pauseMenuUI;

    public LevelInfo levelInfo;

    public Text modeText;    
    public Text ShotsLeftCount;

    public Text LevelCount;
    public Text GoldCount;
    public Text SilverCount;
    public Text BronzeCount;
    public Text MedalText;

    public void UpdateShotsleft(int count)
    {        
        ShotsLeftCount.text = count.ToString();
    }

    public void UpdateLevelCount(int count)
    {
        LevelCount.text = count.ToString();
    }

    public void UpdateMedalCount(int goldCount, int silverCount, int bronzeCount)
    {
        GoldCount.text = goldCount.ToString();
        SilverCount.text = silverCount.ToString();
        BronzeCount.text = bronzeCount.ToString();
    }

    public void UIMainMenu()
    {
        DisableAllUIPanels();
        mainMenuUI.SetActive(true);
    }
    public void UILevelSelect()
    {
        DisableAllUIPanels();
        levelSelectUI.SetActive(true);
    }

    public void UIGamePlay() // same as UIRolling.. consider merging them into one method for UIGameplay? make sure there are no issues first
    {
        DisableAllUIPanels();
        gamePlayUI.SetActive(true);
    }

    public void UILevelFailed()
    {
        DisableAllUIPanels();
        levelFailedUI.SetActive(true);
    }

    public void UILevelComplete()
    {
        DisableAllUIPanels();

        if (_gameManager.shotsLeft >= levelInfo.ShotsToComplete - levelInfo.GoldMedal) MedalText.text = "Medal: Gold";
        else if (_gameManager.shotsLeft >= levelInfo.ShotsToComplete - levelInfo.SilverMedal) MedalText.text = "Medal: Silver";
        else if (_gameManager.shotsLeft >= levelInfo.ShotsToComplete - levelInfo.BronzeMedal) MedalText.text = "Medal: Bronze";
        else MedalText.text = "Medal: None";

        levelCompleteUI.SetActive(true);
    }

    public void UIGameComplete()
    {
        DisableAllUIPanels();
        gameCompleteUI.SetActive(true);
    }

    public void UIPaused()
    {
        DisableAllUIPanels();
        pauseMenuUI.SetActive(true);
    }

    public void DisableAllUIPanels()
    {
        gamePlayUI.SetActive(false);
        mainMenuUI.SetActive(false);
        levelSelectUI.SetActive(false);
        levelCompleteUI.SetActive(false);
        gameCompleteUI.SetActive(false);
        levelFailedUI.SetActive(false);
        pauseMenuUI.SetActive(false);
    }



}
