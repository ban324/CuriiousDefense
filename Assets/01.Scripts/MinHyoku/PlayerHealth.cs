using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
	public int currentHealth = 100;
    

	public HealthBar healthBar;

    // Start is called before the first frame update
    private void Awake()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
    }
    private void Start()
    {
        healthBar.SetHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			TakeDamage(20);
		}
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            HealHealth(20);
        }
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
    public void HealHealth(int healCount)
    {
        currentHealth += healCount;

        healthBar.SetHealth(currentHealth);
    }
    public void Shealth()
    {
        healthBar.SetHealth(currentHealth);

    }
}
