using E.AccesoDatos;
using E.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.LogicaNegocio
{
    public class PersonaE_LogicaNegocio
    {
        public static async Task<PersonaE> GetById(int id)
        {
            return await PersonaE_AccesoDatos.GetById(id);
        }

        public static async Task<int> Create(PersonaE pPersonaE)
        {
            return await PersonaE_AccesoDatos.Create(pPersonaE);
        }
        public static async Task<int> Update(PersonaE pPersonaE)
        {
            return await PersonaE_AccesoDatos.Update(pPersonaE);
        }
        public static async Task<int> Delete(PersonaE pPersonaE)
        {
            return await PersonaE_AccesoDatos.Delete(pPersonaE);
        }
        public static async Task<List<PersonaE>> GetAll()
        {
            return await PersonaE_AccesoDatos.GetAll();
        }
    }
}
