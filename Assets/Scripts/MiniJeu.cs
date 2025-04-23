using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniJeu : MonoBehaviour
{
    public float pointageTemps;
    public TextMeshProUGUI textScore;

    void Start()
    {
        pointageTemps = 0;
    }

    private void Update()
    {
        textScore.text = pointageTemps.ToString("00.00");
    }

    public void TraiterDefaite()
    {
        Debug.Log("Defaite!");
        float recordActuel = PlayerPrefs.GetFloat("meilleurScore", 0f);
        if (pointageTemps >= recordActuel)
        {
            Invoke("MontrerPanneauNouveauRecord", 3f);
        }
    }
}
