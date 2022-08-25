using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoomGeneration : MonoBehaviour
{
    [SerializeField] GameObject[] newRoom;
    [SerializeField] float RoomOffset = 5;
    [SerializeField] bool genOnRun;
    [SerializeField] int roomCount;

    private void Awake()
    {
        if (genOnRun) generateRoom(roomCount);
    }
    void generateRoom(int count)
    {
        Vector2[] roomOff = { new Vector2(RoomOffset, 0), new Vector2(-RoomOffset, 0), new Vector2(0, -RoomOffset), new Vector2(0, RoomOffset) };
        int[] roomList = new int[4];
        List<int> roomAvInList = Enumerable.Range(0, 4).ToList();
        for (int i = 0; i < count; i++)
        {
            int randRoomInd = Random.Range(0, roomAvInList.Count);
            roomList[roomAvInList[randRoomInd]] = 1;
            roomAvInList.RemoveAt(randRoomInd);
        }
        for (int i = 0; i < roomList.Length; i++)
        {
            Debug.Log(roomList[i]);
            if (roomList[i] == 1)
            { GameObject newNewRoom = Instantiate(newRoom[Random.Range(0, newRoom.Length)], transform.position + new Vector3(roomOff[i].x, roomOff[i].y, 0), transform.rotation); }
        }
    }
}
