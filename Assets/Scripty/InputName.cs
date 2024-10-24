using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InputName : MonoBehaviour
{
    public bool isPlayer;
    public TMP_InputField inputField;
  
    void Start()
    {
        inputField.onValueChanged.AddListener(UpdateName);
    }

    // Update is called once per frame
    private void UpdateName(string name)
    {
        if (isPlayer)
            SaveControler.Instance.namePlayer = name;
        else
            SaveControler.Instance.nameEnemy = name;
        
        
    }
}
