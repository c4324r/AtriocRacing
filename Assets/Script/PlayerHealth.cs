using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;

    void OnTriggerStay2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "shock": 
                health -= .15f;
                break;
            case "heal":
                if (health <= 100f)
                {
                    health += .5f ;
                }
                break;
            case "end":
                CompletionManager.check[SceneManager.GetActiveScene().buildIndex] = true;
                SceneManager.LoadScene(1);
                break;
        }
        Debug.Log(collision.gameObject.tag);
    }
}
