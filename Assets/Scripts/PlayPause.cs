using UnityEngine;
using UnityEngine.UI;
public class PlayPause : MonoBehaviour
{
    public static bool isPaused = false;
    public Image playpauseButton, optionsButton;
    public Sprite pauseSprite, playSprite, optionsSprite;
    
    public void TogglePause()
    {
        isPaused = Mathf.Approximately(Time.timeScale, 0.0f) ? false : true;
        if(isPaused==true)
        {
            Time.timeScale = 0.0f;
            playpauseButton.sprite = playSprite;
        }
        else
        {
            Time.timeScale = 1.0f;
            playpauseButton.sprite = pauseSprite;
        }
    }
}