using System;

namespace GameDemo.Entities
{
    internal interface IGamer
    {
        public string GamerName { get; set; }
        public string GamerSurname { get; set; }
        public string TcNo { get; set; }
        public int BirthYear { get; set; }
    }
}