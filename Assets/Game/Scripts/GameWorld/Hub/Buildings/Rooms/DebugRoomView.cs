using Game.Scripts.GameWorld.BuildingGrid;
using Game.Scripts.GameWorld.Buildings.Rooms;
using UnityEngine;

public class DebugRoomView : MonoBehaviour
{
    [SerializeField] private RoomView _roomView;
    [SerializeField] private GridSettings _gridSettings;

    private void OnDrawGizmos()
    {
        if (_roomView == null || _gridSettings == null)
            return;

        var gridSize = _roomView.Size;
        var tileSize = (Vector3)_gridSettings.TileSize;

        for(int x = 0; x < gridSize.x; x++)
        {
            for(int y = 0; y < gridSize.y; y++)
            {
                var center = Vector3.Scale(new Vector3(x, y), _gridSettings.TileSize) + transform.position;

                Gizmos.color = Color.cyan;
                Gizmos.DrawWireCube(center + tileSize / 2, tileSize);
            }
        }
       
    }
}
