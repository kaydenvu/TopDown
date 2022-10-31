using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private HealthManager healhMan;
    public Slider healthBar;
    public Text hpText;
    // Start is called before the first frame update
    void Start()
    {
        healhMan = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = healhMan.maxHP;
        healthBar.value = healhMan.currentHP;
        hpText.text = "HP: " + healhMan.currentHP + "/" + healhMan.maxHP;
    }
}
