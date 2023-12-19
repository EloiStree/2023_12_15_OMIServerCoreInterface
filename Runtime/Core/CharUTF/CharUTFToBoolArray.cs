﻿[System.Serializable]
public class CharUTFToBoolArray : CharUTFToValue<bool>, I_CharUTFToValueBoolean
{
    public CharUTFToBoolArray(string c, bool[] array)
    {
        SetCharAndArray(c, array);
    }
    public CharUTFToBoolArray()
    {
        SetCharAndArray("", new bool[0]);
    }
}
