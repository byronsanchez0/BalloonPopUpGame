using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//IDEA 1 explotar con score like the base game
//IDEA 2 explotar con premio adentro random
public class TouchManager : MonoBehaviour
{
    public float laserLength = 0.3f;
    // Start is called before the first frame update
    int score = 0;
    public GameObject gameOverScreen;
    public GameObject YouWinScreen;
    public TMP_Text Scoretxt;
    void Start()
    {
        
    }
    // Invoke("StartTimer", 3.6f);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D Ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up * laserLength);
            Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up*laserLength, Color.red);
            if (Ray.collider != null)
            {
                if (Ray.collider.gameObject.CompareTag("BalloonTag"))
                {
                    score++;
                    Scoretxt.text = "Score : " + score;
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                    //if (score == 10)
                    //{
                    //    Invoke("youWin", 0.5f);
                    //}
                }
                if(Ray.collider.gameObject.CompareTag("Enemy"))
                {
                    
                    
                    Ray.collider.gameObject.GetComponent<Animator>().SetBool("Destroy", true);
                    Destroy(Ray.collider.gameObject, .4f);
                    
                    
                        Invoke("gameOver", 0.5f);
                    
                       
                    
                    //StartCoroutine(ActivateGameOverScreenAfterDelay());





                }
                //IEnumerator ActivateGameOverScreenAfterDelay()
                //{
                //    yield return new WaitForSeconds(2f);
                //    gameOverScreen.SetActive(true);
                //}
                //Anim.SetBool("Destroy", true); Invoke("gameOver", 2f);

            }

        }
    }
    public void gameOver()
    {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);

    }
    public void youWin()
    {
        
        
            Time.timeScale = 0;
            YouWinScreen.SetActive(true);
        
        //Time.timeScale = 0;
        //gameOverScreen.SetActive(true);

    }

}
