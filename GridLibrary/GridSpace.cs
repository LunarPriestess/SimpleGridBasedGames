using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridLibrary
{
    class GridSpace<TValue>
    {
        private GridNode<TValue>[,] _grid;

        public TValue this[int x, int y] { get => _grid[x, y].Data; set => _grid[x, y].Data = value; }

        public int Rows { get => _grid.GetLength(0); }

        public int Columns { get => _grid.GetLength(1); }

        public GridSpace(int x, int y)
        {
            _grid = new GridNode<TValue>[x, y];
        }

        public List<GridNode<TValue>> GetAllNeighbors(GridNode<TValue> node)
        {
            throw new NotImplementedException();
        }

        public List<GridNode<TValue>> GetOrthogonalNeighbors(GridNode<TValue> node)
        {
            throw new NotImplementedException();
        }

    }
}
