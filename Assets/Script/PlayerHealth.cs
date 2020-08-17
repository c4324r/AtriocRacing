using UnityEngine;

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
                    health++;
                }
                break;
            case "end":
                Debug.Log("You Finished Pog");
                break;
        }
    }
}
