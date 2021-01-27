using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class NewGamer : IGamer
    {
        public int UndertakingYear { get; set; }
        public string GamerName { get; set; }
        public string GamerSurname { get; set; }
        public string TcNo { get; set; }
        public int BirthYear { get; set; }
    }
}
