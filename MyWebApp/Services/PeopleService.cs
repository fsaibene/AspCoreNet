using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;
using Microsoft.EntityFrameworkCore;


namespace MyWebApp.Services
{
    public interface IPeopleService {
        Task<List<Person>> GetAllPeopleAsync();
    }
    public class PeopleService : IPeopleService
    {
        PeopleContext _context;

        public PeopleService(PeopleContext context) {
            _context = context;
        }


        public async Task<List<Person>> GetAllPeopleAsync()
        {
            return await _context.Person.ToListAsync();
        }

    }
}
