using E.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.AccesoDatos
{
    public class PersonaE_AccesoDatos
    {
        public static async Task<PersonaE> GetById(int id)
        {
            var personaE = new PersonaE();
            using (var dbContext = new ComunEDB())
            {
                personaE = await dbContext.PersonaE.FirstOrDefaultAsync(s => s.Id == id);
            }

            return personaE;
        }
        public static async Task<int> Create(PersonaE pPersonaE)
        {
            int result = 0;
            using (var dbContext = new ComunEDB())
            {
                dbContext.Add(pPersonaE);
                result = await dbContext.SaveChangesAsync();
            }

            return result;
        }
        public static async Task<int> Update(PersonaE pPersonaE)
        {
            int result = 0;
            using (var bdContext = new ComunEDB())
            {
                var personaE = await bdContext.PersonaE.FirstOrDefaultAsync(r => r.Id == pPersonaE.Id);
                personaE.NombreE = pPersonaE.NombreE;
                personaE.ApellidoE = pPersonaE.ApellidoE;
                personaE.FechaNacimientoE = pPersonaE.FechaNacimientoE;
                personaE.SueldoE = pPersonaE.SueldoE;
                personaE.EstatusE = pPersonaE.EstatusE;
                personaE.ComentarioE = pPersonaE.ComentarioE;
                bdContext.Update(personaE);
                result = await bdContext.SaveChangesAsync();
            }

            return result;
        }
        public static async Task<int> Delete(PersonaE pPersonaE)
        {
            int result = 0;
            using (var bdContext = new ComunEDB())
            {
                var personaE = await bdContext.PersonaE.FirstOrDefaultAsync(r => r.Id == pPersonaE.Id);
                bdContext.Remove(personaE);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<PersonaE>> GetAll()
        {
            var personaEs = new List<PersonaE>();
            using (var bdContext = new ComunEDB())
            {
                personaEs = await bdContext.PersonaE.ToListAsync();
            }
            return personaEs;
        }
    }
}
