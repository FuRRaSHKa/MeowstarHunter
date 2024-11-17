using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.GameWorld.BuildingGrid
{
    public partial class Grid
    {
        private readonly GridSettings _settings;

        private List<PlaceableObject> _placedObjets = new List<PlaceableObject>();

        public void PlaceObject(Vector2 position, Vector3Int size, GameObject view)
        {
            var gridPos = WorldToGridPosition(position);

            var obj = new PlaceableObject(view, gridPos, gridPos + size);
            _placedObjets.Add(obj);
        }

        public bool IsPlaceAvailable(Vector3 position, Vector3Int size)
        {
            var gridPos = WorldToGridPosition(position);

            var bounds = new Bounds();
            bounds.SetMinMax(gridPos, gridPos + size);

            for(int i = 0; i  < _placedObjets.Count; i++)
            {
                if (_placedObjets[i].Intersects(bounds))
                    return false;
            }

            return true;
        }

        private Vector3Int WorldToGridPosition(Vector2 position)
        {
            var localPos = position - _settings.MaxPos;
            var result = Vector3Int.zero;

            result.x = Mathf.RoundToInt(localPos.x / _settings.TileSize.x);
            result.y = Mathf.RoundToInt(localPos.y / _settings.TileSize.y);
        
            return result;
        }
    }
}
