using System;
using UnityEngine;
using System.Collections.Generic;

public static class AudioSourceExtensions
{
    public static double ConvertSamplesToTime(this AudioSource audioSource,  int samples)
    {
        if(audioSource.clip == null) throw new Exception("Audio clip is null.");
        return samples / (double)audioSource.clip.frequency;
    }

    public static int ConvertTimeToSamples(this AudioSource audioSource, double time)
    {
        if (audioSource.clip == null) throw new Exception("Audio clip is null.");
        return (int)(time * audioSource.clip.frequency);
    }
}