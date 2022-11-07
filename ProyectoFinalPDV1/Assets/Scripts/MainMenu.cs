using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Opciones")]
    public Slider volumeMaster;
    public Slider volumeMusic;
    public Slider volumeFX;
    public Toggle mute;
    public AudioMixer mixer;
    public AudioSource fxSource;
    public AudioClip clickSound;
    private float lastVolume; // guarda el último volume configurado
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject optionsPanel;


    public void Awake()
    {
        volumeMaster.onValueChanged.AddListener(ChangeVolumeMaster);
        volumeFX.onValueChanged.AddListener(ChangeVolumeFX);
        volumeMusic.onValueChanged.AddListener(ChangeVolumeMusic);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SetMute()
    {
        if (mute.isOn)
        {
            mixer.GetFloat("VolMaster", out lastVolume);
            mixer.SetFloat("VolMaster", -80);
        }

        else
            mixer.SetFloat("VolMaster", lastVolume);
    }

    public void OpenPanel(GameObject panel)
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);

        panel.SetActive(true);
        PlaySoundButton();
    }

    public void ChangeVolumeMaster(float v)
    {
        mixer.SetFloat("VolMaster", v);
    }
    public void ChangeVolumeMusic(float v)
    {
        mixer.SetFloat("VolMusic", v);
    }

    public void ChangeVolumeFX(float v)
    {
        mixer.SetFloat("VolFx", v);
    }

    //Sonido click de los botones
    public void PlaySoundButton()
    {
        fxSource.PlayOneShot(clickSound);
    }

    //Carga la siguiente escena para comenzar el juego
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
