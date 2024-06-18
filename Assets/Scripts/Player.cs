using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int gold = 100;
    public int energy = 50;
    public int experience = 0;
    public bool isWorking = false;
    public bool isEating = false;
    public TextMeshProUGUI goldText;   // TextMeshProUGUI 사용
    public TextMeshProUGUI energyText; // TextMeshProUGUI 사용
    public TextMeshProUGUI experienceText; // TextMeshProUGUI 사용

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        UpdateUI();
    }

    public void Feed()
    {
        if (gold >= 10&&isEating==false) // 골드가 충분한지 확인
        {
            gold -= 10;
            energy += 5;
            experience += 1;
            UpdateUI();
            animator.SetTrigger("Feed");
        }
    }

    public void Work()
    {
        if (!isWorking)
        {
            gold += 20;
            energy -= 10;
            experience += 1;
            UpdateUI();
            animator.SetTrigger("Work");
        }
    }

    void UpdateUI()
    {
        goldText.text = "Gold: " + gold;
        energyText.text = "Energy: " + energy;
        experienceText.text = "Experience: " + experience;
    }
}