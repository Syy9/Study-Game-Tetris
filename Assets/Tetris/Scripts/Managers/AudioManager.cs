using UnityEngine;
namespace Syy.Manager
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] AudioClip dropSound;
        [SerializeField] AudioClip lineClearSound;
        [SerializeField] AudioSource musicSource;
        [SerializeField] AudioSource soundSource;
        [SerializeField] AudioClip gameMusic;
        [SerializeField] AudioClip uiClick;
        [SerializeField] AudioClip winSound;
        [SerializeField] AudioClip loseSound;
        [SerializeField] AudioClip popUpOpen;
        [SerializeField] AudioClip poUpClose;

        public void PlayLoseSound()
        {
            StopGameMusic();
            soundSource.clip = loseSound;
            soundSource.Play();
        }

        public void PlayUIClick()
        {
            soundSource.clip = uiClick;
            soundSource.Play();
        }

        public void PlayWinSound()
        {
            StopGameMusic();
            soundSource.clip = winSound;
            soundSource.Play();
        }

        public void PlaySplashScreenSound()
        {

        }

        public void PlayPopUpOpenSound()
        {

        }

        public void PlayPopUpCloseSound()
        {

        }

        public void PlayDropSound()
        {
            soundSource.clip = dropSound;
            soundSource.Play();
        }

        public void PlayLineClearSound()
        {
            soundSource.clip = lineClearSound;
            soundSource.Play();
        }

        public void SetSoundFxVolume(float value)
        {
            float temp = value + soundSource.volume;
            if (temp < 0 || temp > 1)
                return;
            else
                soundSource.volume += value;
        }

        public void PlayGameMusic()
        {
            musicSource.clip = gameMusic;
            musicSource.Play();
        }

        public void StopGameMusic()
        {
            musicSource.Stop();
        }

        public void SetSoundMusickVolume(float value)
        {
            float temp = value + soundSource.volume;
            if (temp < 0 || temp > 1)
                return;
            else
                musicSource.volume += value;
        }
    }
}
