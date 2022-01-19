using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SO_Singleton<T> : ScriptableObject where T : ScriptableObject
{
    private static T instance = null;

    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                T[] results = Resources.FindObjectsOfTypeAll<T>();
                if(results.Length == 0)
                {
                    Debug.LogError("SO_Singleton : results length is 0 of " + typeof(T).ToString());
                }
                if(results.Length > 1)
                {
                    Debug.LogError("SO_Singleton : results length is greater than 1 of " + typeof(T).ToString());
                }

                instance = results[0];
                instance.hideFlags = HideFlags.DontUnloadUnusedAsset;
            }

            return instance;
        }

    }

}
