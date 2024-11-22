using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("Volume Settings")] 
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 1.0f;
    
    [Header("GamePlay Settings")]
    [SerializeField] private TMP_Text controllerSensTextValue = null;
    [SerializeField] private Slider controllerSensSlider = null;
    [SerializeField] private float defaultSens = 4f;
    public float mainControllerSens = 4f;
    
    [Header("Toggle Settings")]
    [SerializeField] private Toggle invertYToggle = null;
    
    [Header("Graphics Settings")]
    [SerializeField] private Slider brightnessSlider = null;
    [SerializeField] private TMP_Text brightnessTextValue = null;
    [SerializeField] private Toggle FullScreen = null;
    [SerializeField] private float defaultBrightness = 1.0f;

    private int _qualityLevel;
    private bool _isFullScreen;
    private float _brightnessLevel;
    
    [Header("Confirmation")]
    [SerializeField] public GameObject confirmationPrompt = null;
    
    [Header("Levels To Load")] 
    public string _newGameLevel;
    private string levelToLoad;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextValue.text = volume.ToString("0.0");
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
    }
    
    public void SetControllerSen()
    {
        mainControllerSens = controllerSensSlider.value;
        controllerSensTextValue.text = mainControllerSens.ToString("0");
    }

    public void GamePlayApply()
    {
        if (invertYToggle.isOn)
        {
            PlayerPrefs.SetInt("masterInvertY", 1);
        }
        else
        {
            PlayerPrefs.SetInt("masterInvertY", 0);
        }
        
        PlayerPrefs.SetFloat("masterSens", mainControllerSens);
        StartCoroutine(ConfirmationBox());

    }

    public void SetBrightness()
    {
        _brightnessLevel = brightnessSlider.value;
        brightnessTextValue.text = brightnessSlider.value.ToString("0.0");
    }

    public void SetFullScreen()
    {
        _isFullScreen = FullScreen.isOn;
    }

    public void Quality()
    {
        
    }

    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            volumeTextValue.text = defaultVolume.ToString("0.0");
            VolumeApply();
        }

        if (MenuType == "Gameplay")
        {
            controllerSensSlider.value = defaultSens;
            mainControllerSens = defaultSens;
            controllerSensTextValue.text = defaultSens.ToString("0");
            invertYToggle.isOn = false;
            GamePlayApply();
        }
    }

    public IEnumerator ConfirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
