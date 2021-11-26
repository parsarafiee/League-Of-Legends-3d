using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    #region Singleton
    private static EnemyManager instance;

    private EnemyManager() { }
    public static EnemyManager Instance
    {
        get
        {
            if (instance == null)
                instance = new EnemyManager();
            return instance;
        }
    }

    #endregion

}
