using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    static AudioManager _current;

    [Header("Ambient Audio")]
    [SerializeField] private AudioClip musicClip;
    [SerializeField] private AudioClip ambientClip;

    [Header("SFX Audio")]
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip canyonClip;
    [SerializeField] private AudioClip enemyBreathClip;
    [SerializeField] private AudioClip stepsClip;

    [Header("Mixer Groups")]
    [SerializeField] AudioMixerGroup ambientGroup;
    [SerializeField] AudioMixerGroup musicGroup;
    [SerializeField] AudioMixerGroup sfxGroup;

    [Header("SceneSound")]
    [SerializeField] private AudioClip winClip;
    [SerializeField] private AudioClip loseClip;

    AudioSource _ambientSource;
    AudioSource _musicSource;
    AudioSource _sfxSource;

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(gameObject);
            return;
        }

        //Este es el audiomanager actual y debe persistir entre escenas
        _current = this;
        DontDestroyOnLoad(gameObject);

        //Genera los canales de audio
        _ambientSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        _musicSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        _sfxSource = gameObject.AddComponent<AudioSource>() as AudioSource;

        //Asigna los canales a cada grupo del mixer
        _ambientSource.outputAudioMixerGroup = ambientGroup;
        _musicSource.outputAudioMixerGroup = musicGroup;
        _sfxSource.outputAudioMixerGroup = sfxGroup;

        //Ejecuta el metodo que inicia los sonidos del nivel
        StartLevelAudio();
    }

    void StartLevelAudio()
    {
        //Asigna la fuente de sonido de ambiente, el loop y reproduce
        _current._ambientSource.clip = _current.ambientClip;
        _current._ambientSource.loop = true;
        _current._ambientSource.Play();
        //Asigna la fuente de sonido de la música, el loop y reproduce
        _current._musicSource.clip = _current.musicClip;
        _current._musicSource.loop = true;
        _current._musicSource.Play();
    }

    public static void JumpPlayerSound()
    {
        if (_current == null)
            return;

        _current._sfxSource.clip = _current.jumpClip;
        _current._sfxSource.loop = false;
        _current._sfxSource.Play();
    }
    //public static void CanyonShot()
    //{
    //    if (_current == null)
    //        return;

    //    _current._sfxSource.clip = _current.canyonClip;
    //    _current._sfxSource.loop = false;
    //    _current._sfxSource.Play();
    //}

    public static void EnemyBreath()
    {
        if (_current == null)
            return;

        _current._sfxSource.clip = _current.enemyBreathClip;
        _current._sfxSource.loop = false;
        _current._sfxSource.Play();
    }
    public static void YouWin()
    {
        if (_current == null)
            return;

        _current._sfxSource.clip = _current.winClip;
        _current._sfxSource.loop = false;
        _current._sfxSource.Play();
    }
    public static void YouLose()
    {
        if (_current == null)
            return;

        _current._sfxSource.clip = _current.loseClip;
        _current._sfxSource.loop = false;
        _current._sfxSource.Play();
    }
}
