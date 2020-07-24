using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMonger : MonoBehaviour
{
    public GameObject player;
 
    public GameObject CompleteLevelUI; 

    private void Update()
    {


       //  if player fill down 
        if (player.transform.position.x < -8 || player.transform.position.x > 8)
        {
            player.GetComponent<Rigidbody>().useGravity = true; // to player fill down 
            Invoke("Restart", 3f);
        }
    }
   

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  //  reload the  same scene
    }
    public void playerWon()
    {
        CompleteLevelUI.SetActive(true);
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //  load the next scene
    }
}
