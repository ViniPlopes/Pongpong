using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveControler : MonoBehaviour
{
    public Color colorPlayer = Color.white;
    public Color colorEnemy = Color.white;

    public static SaveControler _instance;

    public string namePlayer;
    public string nameEnemy;

    public string savewinnerkey = "SavedWinne";
    public static SaveControler Instance
    {
        get
        {
            if(_instance == null)
            {
                
               _instance = FindObjectOfType<SaveControler>();

                if (_instance == null)
                {
                    GameObject singletonObjeto = new GameObject(typeof(SaveControler).Name);
                    _instance = singletonObjeto.AddComponent<SaveControler>();
                }
                
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public string GetName(bool isPlayer)
    {
        return isPlayer ? namePlayer : nameEnemy;
    }

    public void Reset()
    {
        nameEnemy = "";
        namePlayer = "";
        colorEnemy = Color.white;
        colorPlayer = Color.white;
    }

    public void SaveWinner(string winner)
    {
        PlayerPrefs.SetString(savewinnerkey, winner);
    }
    public string GetLastWinner()
    {
        return PlayerPrefs.GetString(savewinnerkey);

        
    }

    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
        
    }
}
