using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCell.World
{
    class Cell
    {
        Guid Id { get; set; }
        List<Cell> Connections;
        Cell Parent;
        DNA DNA;
        int Age = 0;
        int NumberOfFissions = 0;
        float Energy = 1.0f;

        public Cell()
        {
            Id = Guid.NewGuid();
            DNA = new DNA();
            Connections = new List<Cell>();
        }

        public void IncreaseAge()
        {
            this.Age += 1;
        }
    }
}
