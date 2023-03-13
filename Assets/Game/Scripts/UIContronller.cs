using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIContronller : MonoBehaviour
{
    public Slider slidermusic;
    public void ToggleMusic()
    {
        Sound.s_Sound.ToggleMusic();
    }

    public void MusicVolume()
    {
        Sound.s_Sound.MusicVolume(slidermusic.value);
    }
}
