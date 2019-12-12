using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace MarioProva
{
    public class MyObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
    }

    public class MyList
    {
        public List<MyObject> List { get; } = new List<MyObject>
        {
            new MyObject
            {
                Id = 1,
                Name = "Mario",
                Surname = "Fagiolo",
                Number = 33
            },
            new MyObject
            {
                Id = 2,
                Name = "Giovanni",
                Surname = "Panascia",
                Number = 37
            },
            new MyObject
            {
                Id = 3,
                Name = "Damiano",
                Surname = "Bisecco",
                Number = 50
            }

        };
    }
}
