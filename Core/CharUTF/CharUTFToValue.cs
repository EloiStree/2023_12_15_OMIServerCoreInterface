using UnityEngine;

[System.Serializable]
public class CharUTFToValue<T> : I_CharUTFToValue<T>, I_SetCharUTFToValue<T> where T : struct
{
    public string m_charAsIndex;
    public T[] m_stringNameValueArray;


    public void GetChatUniqueId(out string charAsString)
    {
        charAsString = m_charAsIndex;
    }

    public string GetChatUniqueId()
    {
        return m_charAsIndex;
    }

    public void GetValueAsArray(out T[] values)
    {
        values = m_stringNameValueArray;
    }

    public T[] GetValueAsArray()
    {
        return m_stringNameValueArray;
    }

    public void SetCharAndArray(string charAsString, T[] array)
    {
        m_charAsIndex = charAsString;
        m_stringNameValueArray = array;
    }
}


public interface I_CharUTFToValue<T> {

    public void GetChatUniqueId(out string charAsString);
    public string GetChatUniqueId();
    public void GetValueAsArray(out T[] values );
    public T[] GetValueAsArray();
}

public interface I_SetCharUTFToValue<T> {
    public void SetCharAndArray(string charAsString, T[] array);
}

public interface I_CharUTFToValueBoolean : I_CharUTFToValue<bool> { }
public interface I_CharUTFToValueFloat : I_CharUTFToValue<float> { }
public interface I_CharUTFToValueVector3 : I_CharUTFToValue<Vector3> { }
public interface I_CharUTFToValueQuaternion : I_CharUTFToValue<Quaternion> { }
public interface I_CharUTFToValueName: I_CharUTFToValue<string> { }