using LA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.DAL.Interfaces
{
    public interface ICountryRepo
    {
        IEnumerable<Country> GetAll(); //ToList()

        Country GetById(int id); //Find()

        void Save(Country country); //Add()

        void Edit(Country country); //Update()

        void RemoveData(Country country); //Remove()


    }
}
