using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridLibrary;

namespace GridGames
{
    class TestGame
    {

        public GridSpace<bool> GridSpace { get; set; }

        public TestGame(int size)
        {
            GridSpace = new GridSpace<bool>(size, size);
        }



    }
}
