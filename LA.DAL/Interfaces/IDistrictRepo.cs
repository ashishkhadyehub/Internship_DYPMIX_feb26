using LA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.DAL.Interfaces
{
    public interface IDistrictRepo
    {
        IEnumerable<District> GetAll(); //ToList()

        District GetById(int id); //Find()

        void Save(District district); //Add()

        void Edit(District district); //Update()

        void RemoveData(District district); //Remove()

    }
}
