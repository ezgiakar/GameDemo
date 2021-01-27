using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GamerManager
    {
            List<IGamer> players = new List<IGamer>() { };
            public void Add(IGamer player)
            {
                players.Add(player);
                Console.WriteLine("{0} {1}, isimli oyuncu sisteme eklendi.", player.GamerName, player.GamerSurname);
            }

            public void Update(IGamer player, int Id)
            {

            }

            public void Delete(string TcNo)
            {
                foreach (var player in players)
                {
                    if (player.TcNo == TcNo)
                    {
                        players.Remove(player);
                        Console.WriteLine("{0} {1}, isimli oyuncu sistemden silindi.", player.GamerName, player.GamerSurname);
                        break;
                    }

                    else
                    {
                        continue;
                    }
                }

            }

            public void ListPlayer()
            {
                int i = 1;
                foreach (var player in players)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("{0}.Oyuncu\nAd Soyad:{1} {2}\nTc No:{3}\nDoğum Yılı:{4}", i, player.GamerName, player.GamerSurname, player.TcNo, player.BirthYear);
                    Console.WriteLine("--------------------------");
                    i += 1;
                }
            }
        }
}
