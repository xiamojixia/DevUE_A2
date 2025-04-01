using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Setting : MonoBehaviour
{
    public Slider volumeSlider;
    public TextMeshProUGUI volumeText;

    private void Start()
    {
        float volume = PlayerPrefs.GetFloat("Volume", 0.5f);
        volumeSlider.value = volume;
        AudioListener.volume = volume;
        UpdateVolumeText();
    }

    public void OnVolumeChange()
    {
        float volume = volumeSlider.value;
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
        UpdateVolumeText();
    }

    private void UpdateVolumeText()
    {
        volumeText.text = "Volume: " + (int)(volumeSlider.value * 100) + "%";
    }
}
