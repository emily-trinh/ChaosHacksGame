
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    // [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    public int roomNumber = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(collision.transform.position.x < transform.position.x)
                cam.MoveToNewRoom(30 + roomNumber * 30);
            else
                cam.MoveToNewRoom(roomNumber * 30);
        }
    }
}
