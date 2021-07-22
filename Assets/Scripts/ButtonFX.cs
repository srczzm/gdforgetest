using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
    public AudioSource soundFx;
    public AudioClip clickSound;
    public SettingsConroller settings;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SoundOnClick()
    {

        if (settings.IsSoundsOn())
        {
            soundFx.PlayOneShot(clickSound);
        }
    }
}
