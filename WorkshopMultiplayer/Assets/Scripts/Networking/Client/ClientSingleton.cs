using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSingleton : MonoBehaviour
{
    private static ClientSingleton instance;

    public static ClientSingleton Instance
    {
        get
        {
            if (instance == null) { return instance; }
            instance = FindFirstObjectByType<ClientSingleton>();

            if (instance == null)
            {
                Debug.LogError("No ClientSingleton in the scene!");
                return null;
            }

            return instance;
        }
    }
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
