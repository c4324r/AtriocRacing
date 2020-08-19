using UnityEngine;

public class StateRenderer : MonoBehaviour
{
    private int x = 0;
    void Start()
    {
        for (int i = 0; i < CompletionManager.check.Length; i++)
        {
            if (CompletionManager.check[i])
            {
                x++;
                Destroy(GameObject.FindGameObjectWithTag(CompletionManager.names[i]));
            }
        }
        if (x == 10)
        {
            Destroy(GameObject.FindGameObjectWithTag("blockade"));
        }
    }
}
