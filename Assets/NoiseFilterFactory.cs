using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NoiseFilterFactory
{
    public static INoiseFilter CreateNoiseFilter(NoiseSettings noiseSettings)
    {
        switch (noiseSettings.filterType)
        {
            case NoiseSettings.FilterType.Simple:
                return new SimpleNoiseFilter(noiseSettings.simpleNoiseSettings);
            case NoiseSettings.FilterType.Rigid:
                return new RigidNoiseFilter(noiseSettings.rigidNoiseSettings);
        }

        return null;
    }
}
