using System;
using System.Text;
using System.Collections.Generic;

namespace GridLibrary
{
    /// <summary>
    /// A grid of <see cref="GridNode{TValue}"/> used in grid based games.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    class GridSpace<TValue>
    {
        /// <summary>
        /// The grid of <see cref="GridNode{TValue}"/> that make up the <see cref="GridSpace{TValue}"/>.
        /// </summary>
        private GridNode<TValue>[,] _grid;

        /// <summary>
        /// An array of all eight posible directions in the grid.
        /// </summary>
        private Direction[] _gridDirections = { Direction.North, Direction.South, Direction.East, Direction.West, 
                                                Direction.NorthEast, Direction.SouthEast, Direction.NorthWest, Direction.SouthWest };

        /// <summary>
        /// Public indexer that gets/sets the data value for a specific node in the <see cref="GridSpace{TValue}"/>.
        /// </summary>
        /// <param name="x">The node's X value.</param>
        /// <param name="y">The node's Y value.</param>
        /// <returns>The data value for the node located at (<paramref name="x"/>, <paramref name="y"/>).</returns>
        public TValue this[int x, int y] 
        { 
            get 
            {
                if (x < 0 || x >= _grid.GetLength(0)) return default;
                else if (y < 0 || y >= _grid.GetLength(1)) return default;
                else return _grid[x, y].Data;
            }
            set
            {
                if (x < 0 || x >= _grid.GetLength(0)) throw new ArgumentException("Invalid X value.");
                else if (y < 0 || y >= _grid.GetLength(1)) throw new ArgumentException("Invalid Y value.");
                else _grid[x, y].Data = value;
            }
        }

        /// <summary>
        /// The number of rows in the grid.
        /// </summary>
        public int Rows { get => _grid.GetLength(0); }

        /// <summary>
        /// The number of columns in the grid.
        /// </summary>
        public int Columns { get => _grid.GetLength(1); }

        /// <summary>
        /// Intializes a new instance of the <see cref="GridSpace{TValue}"/> class.
        /// </summary>
        /// <param name="x">The number of rows in the grid.</param>
        /// <param name="y">The number of columns in the grid.</param>
        public GridSpace(int x, int y)
        {
            _grid = new GridNode<TValue>[x, y];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    _grid[i, j] = new GridNode<TValue>(i, j);
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="GridSpace{TValue}"/> class with a specific starting data value for the nodes.
        /// </summary>
        /// <param name="x">The number of rows in the grid.</param>
        /// <param name="y">The number of columns in the grid.</param>
        /// <param name="value">The nodes' starting data value.</param>
        public GridSpace(int x, int y, TValue value)
        {
            _grid = new GridNode<TValue>[x, y];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    _grid[i, j] = new GridNode<TValue>(i, j, value);
        }

        /// <summary>
        /// Gets the eight surrounding node's data values.
        /// </summary>
        /// <param name="x">The source node's X value.</param>
        /// <param name="y">The source node's Y value.</param>
        /// <returns>The data values for all the surrounding <see cref="GridNode{TValue}"/>.</returns>
        public List<TValue> GetAllNeighbors(int x, int y)
        {
            List<TValue> values = new List<TValue>();
            foreach (Direction direction in _gridDirections) values.Add(GetNeighbor(x, y, direction));
            return values;
        }

        /// <summary>
        /// Gets the orthogonaly adjacent node's data values.
        /// </summary>
        /// <param name="x">The source node's X value.</param>
        /// <param name="y">The source node's Y value.</param>
        /// <returns>The data values for all the orthogonally adjacent <see cref="GridNode{TValue}"/>.</returns>
        public List<TValue> GetOrthogonalNeighbors(int x, int y)
        {
            List<TValue> values = new List<TValue>();
            for (int i = 0; i < _gridDirections.Length / 2; i++) values.Add(GetNeighbor(x, y, _gridDirections[i]));
            return values;
        }

        /// <summary>
        /// Gets the neighboring node's data value.
        /// </summary>
        /// <param name="x">The source node's X value.</param>
        /// <param name="y">The source node's Y vlaue.</param>
        /// <param name="direction">The <see cref="Direction"/> to look in.</param>
        /// <returns>The data value of the <see cref="GridNode{TValue}"/> in that <see cref="Direction"/>.</returns>
        public TValue GetNeighbor(int x, int y, Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return this[x, y - 1];
                case Direction.South:
                    return this[x, y + 1];
                case Direction.East:
                    return this[x + 1, y];
                case Direction.West:
                    return this[x - 1, y];
                case Direction.NorthEast:
                    return this[x + 1, y - 1];
                case Direction.SouthEast:
                    return this[x + 1, y + 1];
                case Direction.NorthWest:
                    return this[x - 1, y - 1];
                case Direction.SouthWest:
                    return this[x - 1, y + 1];
                default:
                    throw new InvalidDirectionException("That Direction Does not exist.");
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (GridNode<TValue> node in _grid) builder.Append($"[{node}] ");
            return builder.ToString();
        }
    }
}