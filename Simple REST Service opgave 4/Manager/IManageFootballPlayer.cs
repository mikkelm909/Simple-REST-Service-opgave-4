using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_REST_Service_opgave_4.Manager
{
    interface IManageFootballPlayer
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int id);
        bool Create(FootballPlayer value);
        bool Update(int id, FootballPlayer value);
        FootballPlayer Delete(int id);
    }
}
