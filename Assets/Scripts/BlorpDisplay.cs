using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlorpDisplay : MonoBehaviour
{
    [SerializeField] int blorp = 100;
    Text blorpText;

    void Start()
    {
        blorpText = GetComponent<Text>();

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        blorpText.text = blorp.ToString();
    }

    public bool HaveEnoughBlorp(int amount)
    {
        return blorp >= amount;
    }

    public void AddBlorp(int amount)
    {
        blorp += amount;
        UpdateDisplay();
    }

    public void SpendBlorp(int amount)
    {
        if (blorp >= amount)
        {
            blorp -= amount;
            UpdateDisplay();
        }
    }
}
