using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    Vector2 mousePos;
    Vector3 point;
    //counter 3 max if spawned one +1 else if one gone then -1

    int counter = 0;
    bool canSpawn = true;
    
    //MY BALL;
    [SerializeField]GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1. get position 
        // 2. spawn.
        
        
    
    }

    // Update is called once per frame
    void Update()
    {
        if (counter >= 3)
        {
            return; // RETURN MEANS STOP THIS FUNCTION6
        }
        
        mousePos = Input.mousePosition;
        // set the mousePos variable to the position of the mouse click (screen space)

        point = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));
        // set my spawn point variable by converting mousePos from screen space into world space


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Instaniate.
            Instantiate(ball, point, Quaternion.identity);
        }
    }
}
