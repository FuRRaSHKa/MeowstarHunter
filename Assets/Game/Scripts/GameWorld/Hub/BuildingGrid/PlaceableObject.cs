
using UnityEngine;

namespace Game.Scripts.GameWorld.BuildingGrid
{
    public class PlaceableObject
    {
        private readonly GameObject _view;

        private readonly Bounds _bounds;

        public Bounds Bounds => _bounds;

        public PlaceableObject(GameObject view, Vector3Int min, Vector3Int max)
        {
            _view = view;
            _bounds = new Bounds();

            _bounds.SetMinMax(min, max); 
        }

        public bool Intersects(Bounds bounds)
        {
            return _bounds.Intersects(bounds);
        }
    }
}

