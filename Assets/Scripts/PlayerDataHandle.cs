using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    //Static class for save the current player data
    //Singleton pattern

    public static PlayerDataHandle Instance;
    public string PlayerName;
    public int Score;


    
    void Awake()
    {
       if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

   
}
