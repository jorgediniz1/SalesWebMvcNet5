using SalesWebMvc2.Data;
using SalesWebMvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvc2Context _context;

        public SalesRecordService(SalesWebMvc2Context context)
        {
            _context = context;
        }

        public List<SalesRecord> FindAll()
        {
            return _context.SalesRecord.ToList();
        }
    }
}
