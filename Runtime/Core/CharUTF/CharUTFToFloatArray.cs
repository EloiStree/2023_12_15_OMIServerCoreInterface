﻿using UnityEngine.Events;

[System.Serializable]

public class CharUTFToFloatArray : CharUTFToValue<float>, I_CharUTFToValueFloat
{

    public CharUTFToFloatArray(string c, float[] array)
    {
        SetCharAndArray(c, array);
    }
    public CharUTFToFloatArray()
    {
        SetCharAndArray("",new float[0]);
    }
}
