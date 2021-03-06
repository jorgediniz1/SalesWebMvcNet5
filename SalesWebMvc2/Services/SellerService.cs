using SalesWebMvc2.Data;
using SalesWebMvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc2Context _context;

        public SellerService(SalesWebMvc2Context context)
        {
            _context = context;
        }


        //Operação do EF que retorna do DB todos os vendedores. 
        public List<Seller> FindAll()
        {
           return _context.Seller.ToList();
        }



    }
}
