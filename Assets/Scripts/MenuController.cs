using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public AudioSource m_MusicSource;
    public AudioSource m_SoundSource;
    public GameObject MusicSetting;
    public GameObject SoundSetting;
    public SettingsConroller settings;

    private void Awake()
    {
        string a1, a2 = "";
        if (PlayerPrefs.HasKey("Music"))
        {
            a1 = PlayerPrefs.GetString("Music");
            a2 = PlayerPrefs.GetString("Sounds");
            MusicSetting.GetComponent<Toggle>().isOn = bool.Parse(a1);
            SoundSetting.GetComponent<Toggle>().isOn = bool.Parse(a2);
            settings.SetSounds(bool.Parse(a2));
            if (MusicSetting.GetComponent<Toggle>().isOn == false)
            {
                m_MusicSource.Stop();
            }

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPressed()
    {
        LoadingLevel.loadLevel = "Game";
        //LoadingLevel.Load();
        //SceneManager.LoadScene("Game");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
