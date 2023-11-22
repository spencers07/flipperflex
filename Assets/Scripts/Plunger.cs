using UnityEngine;

public class Plunger : MonoBehaviour
{
    private GameObject ball;

    private SpringJoint springJoint;

    void Start()
    {
        springJoint = GetComponent<SpringJoint>();
    }

    void Update()
    {
        springJoint.maxDistance = 2;
    
        if (Input.GetKeyDown(KeyCode.Space)) {
            springJoint.maxDistance = 0;
        }
    }
}
