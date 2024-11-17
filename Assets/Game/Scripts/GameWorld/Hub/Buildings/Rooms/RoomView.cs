using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.GameWorld.Buildings.Rooms
{
    public class RoomView : MonoBehaviour
    {
        [SerializeField] private Vector2Int _size;

        public Vector2Int Size => _size;
    }

}
