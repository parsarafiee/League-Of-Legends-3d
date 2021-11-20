using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    MovementPlayer playerMove;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = FindObjectOfType<MovementPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Right mouse Button=
        bool RMB = Input.GetMouseButtonDown(1);

        if (RMB)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray,out hit) && hit.transform.tag =="Ground")
            {
                playerMove.ReciveNewPositon(hit.point);
                Debug.Log(hit.point);
            }
        }
        
    }
}
