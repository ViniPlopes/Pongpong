using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainMenuCorntroler : MonoBehaviour
{
    public TextMeshProUGUI uiWinner;
    void Start()
    {
        SaveControler.Instance.Reset();
        string LasatWinner = SaveControler.Instance.GetLastWinner();

        if (LasatWinner != "")
            uiWinner.text = "Último vencedor: " + LasatWinner;
        else
            uiWinner.text = "";
    }

}
