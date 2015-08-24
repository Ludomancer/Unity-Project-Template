using System;
using UnityEngine;
using System.Collections.Generic;

public static class AudioSourceExtensions
{
    /// <summary>
    /// Converts samples to time depending on the frequency of the AudioSource.
    /// </summary>
    /// <param name="audioSource"></param>
    /// <param name="samples"></param>
    /// <returns></returns>
    public static double ConvertSamplesToTime(this AudioSource audioSource,  int samples)
    {
        if(audioSource.clip == null) throw new Exception("Audio clip is null.");
        return samples / (double)audioSource.clip.frequency;
    }

    /// <summary>
    /// Converts time to samples depending on the frequency of the AudioSource.
    /// </summary>
    /// <param name="audioSource"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    public static int ConvertTimeToSamples(this AudioSource audioSource, double time)
    {
        if (audioSource.clip == null) throw new Exception("Audio clip is null.");
        return (int)(time * audioSource.clip.frequency);
    }
}