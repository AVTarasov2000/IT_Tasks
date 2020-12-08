using System.Collections.Generic;

namespace task8Library
{
    public class Route
    {
        public List<Coordinates> ListCoordinates { get; }
        private int _index = 0;

        public Route(List<Coordinates> listCoordinates)
        {
            ListCoordinates = listCoordinates;
        }

        public Coordinates Next()
        {
            if (_index < ListCoordinates.Count-1)
            {
                _index++;
            }
            else
            {
                _index = 0;
            }

            return ListCoordinates[_index];
        }
    }
}