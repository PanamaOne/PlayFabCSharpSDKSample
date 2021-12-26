using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager
{
    public static string UserId
    {
        get => PlayerPrefs.GetString("UserId");

        set
        {
            PlayerPrefs.SetString("UserId", value);
            PlayerPrefs.Save();
        }
    }
}
