using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc2.Models;
using SalesWebMvc2.Models.Enums;

namespace SalesWebMvc2.Data
{   //Class de serviço para popular base de dados. 
    public class SeedingServices
    {
        //registro de dependencia com o DbContext
        private SalesWebMvc2Context _context; 


        //quando um SeedingService for criado, automaticamente ele vai receber uma instancia do context também.

        public SeedingServices(SalesWebMvc2Context context)
        {
            _context = context;
        }



        //Operação responsavel por popular a base de dados
        //Testa se ja exista algum dado na base de dados 
        //Operação Any() testa se já existe algum registro na tabela. 
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(new int(), "Computers");
            Department d2 = new Department(new int(), "Eletronics");
            Department d3 = new Department(new int(), "Fashion");
            Department d4 = new Department(new int(), "Books");

            Seller s1 = new Seller(0, "Jorge Diniz", "jorge@gmail.com", new DateTime (2000,3,23), 5000, d1);
            Seller s2 = new Seller(0, "Maria Green", "Maria@gmail.com", new DateTime (1979,12,27), 5000, d2);
            Seller s3 = new Seller(0, "Alex Gray", "Alex@gmail.com", new DateTime (1988,2,20), 5000, d1);
            Seller s4 = new Seller(0, "Martha Red", "Martha@gmail.com", new DateTime (2001,8,13), 5000, d4);
            Seller s5 = new Seller(0, "Donald Blue", "Donald@gmail.com", new DateTime (1993,3,10), 5000, d3);
            Seller s6 = new Seller(0, "Alex Pink", "Alex@gmail.com", new DateTime (1997,7,14), 5000, d2);

            SalesRecord r1 = new SalesRecord(0, new DateTime(2018, 08, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(0, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(0, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(0, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(0, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(0, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(0, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(0, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(0, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(0, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(0, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(0, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(0, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(0, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(0, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(0, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(0, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(0, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(0, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(0, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(0, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(0, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(0, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(0, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(0, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(0, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(0, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(0, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(0, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(0, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

            //Adicionando objetos no banco de dados com EF. 
            //AddRange() método que permite add varias obj de uma vez.
            _context.Department.AddRange(d1, d2, d3, d4);
            
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                );

            //Salva e confirma alterações no banco de dados.
            _context.SaveChanges();

        }



    }
}
