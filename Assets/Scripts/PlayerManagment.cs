using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManagment : MonoBehaviour
{
    public GameManager gameManager;
    public float health = 100;
    public TextMeshProUGUI healthText;
  
    public void Hit(float damage)
    {
        health -= damage;
        healthText.text = $"{health} HP";

        if(health <= 0)
        {
            gameManager.GameOver();
            //SceneManager.LoadScene(0);
        }
    }
}
