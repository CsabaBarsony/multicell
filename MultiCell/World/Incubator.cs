using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCell.World
{
    class Incubator
    {
        public List<Cell> Cells { get; set; }

        public Incubator()
        {
            Cells = new List<Cell>();
            Cells.Add(new Cell());
        }

        public void StartIncubation()
        {
            for (int i = 0; i < 100; i++)
            {

            }
        }
    }
}
