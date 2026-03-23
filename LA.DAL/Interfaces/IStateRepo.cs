using LA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.DAL.Interfaces
{
    public interface IStateRepo
    {
        IEnumerable<State> GetAll(); //ToList()

        State GetById(int id); //Find()

        void Save(State state); //Add()

        void Edit(State state); //Update()

        void RemoveData(State state); //Remove()

    }
}
