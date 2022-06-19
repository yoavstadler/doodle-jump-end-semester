using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lostCanvasScipt : MonoBehaviour
{
    public GameObject menuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restartGame() // לולאת התחלת המשחק מחדש
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // מתחיל את הסצנה הנוכחית מחדש
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
