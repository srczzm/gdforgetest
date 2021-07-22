using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsConroller : MonoBehaviour
{
    public AudioSource m_MusicSource;
    public AudioSource m_SoundSource;
    private bool isMusicPlay = true;
    private bool isSoundPlay = true;
    public string politicURL = "";
    public string gamepageURL = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MusicToggle()
    {

        if (isMusicPlay == false)
        {
            m_MusicSource.Play();
            isMusicPlay = true;
        }
        else
        {
            m_MusicSource.Stop();
            isMusicPlay = false;
        }

        SaveGame();

    }
    public void SoundToggle()
    {
        if (isSoundPlay == false)
        {
            isSoundPlay = true;
        }
        else
        {
            isSoundPlay = false;
        }

        SaveGame();
    }

    public bool IsSoundsOn()
    {
        return isSoundPlay;
    }
    public void SetSounds(bool a)
    {
        isSoundPlay = a;
    }
    void SaveGame()
    {
        PlayerPrefs.SetString("Music", isMusicPlay.ToString());
        PlayerPrefs.SetString("Sounds", isSoundPlay.ToString());
        PlayerPrefs.Save();
    }

    public void PoliticPressed()
    {
        Application.OpenURL(politicURL);
    }

    public void GamepagePressed()
    {
        Application.OpenURL(gamepageURL);
    }

}
