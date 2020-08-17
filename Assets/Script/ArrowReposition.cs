using UnityEngine;

public class ArrowReposition : MonoBehaviour
{
    private Camera cam;
    private float time = 5f;
    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
            gameObject.GetComponent<Renderer>().enabled = true;
            time = 0f;
        }

        if(time >= 2f)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
