namespace GridLibrary
{
    /// <summary>
    /// A single node of a larger grid with type <see cref="TValue"/>.
    /// </summary>
    /// <typeparam name="TValue">The data type of the grid node.</typeparam>
    internal class GridNode<TValue>
    {
        /// <summary>
        /// The data value for this <see cref="GridNode{TValue}"/>.
        /// </summary>
        public TValue Data { get; set; }

        /// <summary>
        /// The X value of this node in a <see cref="GridSpace{TValue}"/>.
        /// </summary>
        public int X { get; set; }
 
        /// <summary>
        /// The Y value of this node in a <see cref="GridSpace{TValue}"/>.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Intializes a new instance of the <see cref="GridNode{TValue}"/> class.
        /// </summary>
        /// <param name="x">The node's X value.</param>
        /// <param name="y">The node's Y value.</param>
        public GridNode(int x, int y)
        {
            X = x;
            Y = y;
            Data = default;
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="GridNode{TValue}"/> class with a specific data value.
        /// </summary>
        /// <param name="x">The node's X value.</param>
        /// <param name="y">The node's Y value.</param>
        /// <param name="value">The node's Data value.</param>
        public GridNode(int x, int y, TValue value)
        {
            X = x;
            Y = y;
            Data = value;
        }

        public override string ToString()
        {
            return $"({X}, {Y}): {Data}";
        }
    }
}
