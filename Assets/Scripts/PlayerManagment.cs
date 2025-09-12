using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManagment : MonoBehaviour
{
    public float health = 100;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Hit(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
