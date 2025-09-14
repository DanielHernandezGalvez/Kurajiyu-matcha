using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int enemiesAlive;
    public int round;
    public GameObject[] spawnPoints;
    public GameObject enemyPrefab;
    public TextMeshProUGUI roundText;
    public GameObject gameOverPanel;
    public TextMeshProUGUI roundsSurvivedText;
    void Start()
    {
        
    }

    void Update()
    {
        if(enemiesAlive == 0)
            {
                round++;
                roundText.text = $"Round: {round}" ;
                NextWave(round);
            }
    }

    public void NextWave(int round)
    {
        for (int i = 0; i < round; i++)
        {
            int randomPos = Random.Range(0, spawnPoints.Length);
            GameObject spawnPoint = spawnPoints[randomPos];

            GameObject enemyInstance = Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
            enemyInstance.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();
            enemiesAlive++;
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        roundsSurvivedText.text = round.ToString();

        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }

}
