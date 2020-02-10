using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    //getting the different rooms for later generation
    public GameObject TreasureRoom;
    public GameObject Room;
    public GameObject Hallway;

    //declaring public gameobjects that are the spheres on the edge of each walkway
    public GameObject[] TreasureConnections;
    public GameObject[] RoomConnections;
    public GameObject[] HallwayConnections;
    
    public Transform start;

    private Random rand; //random variable for random generation

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //starting from start point: random generation begins
        transform.position = new Vector3(start.position.x, start.position.y, start.position.z);
    }
}
