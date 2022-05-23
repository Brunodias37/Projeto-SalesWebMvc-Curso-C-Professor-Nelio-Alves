using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _contexts;


        public SeedingService(SalesWebMvcContext context)
        {
            _contexts = context;
        }

        public void Seed()
        {
            if (_contexts.Department.Any() || _contexts.Seller.Any() || _contexts.SalesRecords.Any())
            {
                return; //o banco de dados já foi populado
            }

            Department d1 = new Department("Computers");
            Department d2 = new Department("Electronics");
            Department d3 = new Department("Fashion");
            Department d4 = new Department("Books");

            Seller s1 = new Seller("Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller("Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller( "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller( "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller( "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller( "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecords r1 = new SalesRecords( new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecords r2 = new SalesRecords( new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecords r3 = new SalesRecords( new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecords r4 = new SalesRecords( new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecords r5 = new SalesRecords( new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecords r6 = new SalesRecords( new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecords r7 = new SalesRecords( new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecords r8 = new SalesRecords( new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecords r9 = new SalesRecords( new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecords r10 = new SalesRecords( new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecords r11 = new SalesRecords( new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecords r12 = new SalesRecords( new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecords r13 = new SalesRecords( new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecords r14 = new SalesRecords( new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecords r15 = new SalesRecords( new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecords r16 = new SalesRecords( new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecords r17 = new SalesRecords( new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecords r18 = new SalesRecords( new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecords r19 = new SalesRecords( new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecords r20 = new SalesRecords( new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecords r21 = new SalesRecords( new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecords r22 = new SalesRecords( new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecords r23 = new SalesRecords( new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecords r24 = new SalesRecords( new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecords r25 = new SalesRecords( new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecords r26 = new SalesRecords( new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecords r27 = new SalesRecords( new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecords r28 = new SalesRecords( new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecords r29 = new SalesRecords( new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecords r30 = new SalesRecords( new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

            _contexts.Department.AddRange(d1, d2, d3, d4);

            _contexts.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _contexts.SalesRecords.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _contexts.SaveChanges();

        }


    }
}
