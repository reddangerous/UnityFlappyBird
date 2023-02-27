using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public float scrollSpeed = -1.5f;
    public bool isgameOver = false;
    private int score = 0;
    public TMP_Text ScoreText;
    public GameObject gameOverText;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
{
    if (isgameOver == true && Input.GetMouseButtonDown(0)){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


    public void Score(){
        if (isgameOver){
            return;
        }
        score++;
        ScoreText.text = "Score: " + score.ToString();
    }
    public void Die()
    {
        isgameOver = true;
        gameOverText.SetActive(true);
    }
}
