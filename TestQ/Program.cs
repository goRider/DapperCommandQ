using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RandomNameGeneratorLibrary;
using TestQ.DbSeedGenerator;
using TestQ.Models;
using TestQ.Services.Commands.MGTSEmployee;
using TestQ.Services.UnitOfWork;

namespace TestQ
{
    class Program
    {
        private const string ConnectionString =
            @"Server=DESKTOP-U64RJVE\SQLEXPRESS;Database=FakeIgn;Trusted_Connection=True;MultipleActiveResultSets=true";

        private List<string> _firstNameList;

        private async Task AddUser()
        {
            const int listSize = 100000;
            var factory = new UnitOfWorkFactory(ConnectionString);

            using (var uow = factory.Create(true))
            {
                try
                {
                    await uow.ExecuteAsync(new AddMGTSEmployeesQuery(new MGTSEmployee
                    {
                        LawsonCompanyCode = "15805",
                        MremployeeCode = 540,
                        Smtpaddress = "George.Okello@maritz.com",
                        LastName = "Okello",
                        FirstName = "George",
                        MiddleInitial = "W",
                        FullName = "George W Okello",
                        PreferredName = "George",
                        Extension = "78825",
                        PhoneNo = "3145565341",
                        Title = "Analyst Developer I",
                        HireDate = DateTime.Now,
                        ActiveFlag = "1",
                        Ssn = "9999"
                    }));

                    uow.Commit();

                    uow.Dispose();


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }

        static void Main(string[] args)
        {
            var maleAttrValue = new UserAttributeValue();
            maleAttrValue.AddMaleEmpAttributes(1100, 500, 500);
            Console.ReadLine();
        }

        static void AddMaleNames(int seedCount, int nameCount, int iterationCount)
        {
            Random rand = new Random(seedCount);
            var genMales = new PersonNameGenerator(rand);
            var firstNameList = genMales.GenerateMultipleMaleFirstNames(nameCount).ToList();
            var lastNameList = genMales.GenerateMultipleLastNames(nameCount).ToList();
            List<MGTSEmployee> mgtsList = new List<MGTSEmployee>();
            var mgts = new MGTSEmployee();
            int id = 0;

            for (int i = 0; i < iterationCount; i++)
            {
                mgts.FirstName = firstNameList[i];
                mgts.LastName = lastNameList[i];
                mgtsList.Add(mgts);
                id += i;
                Console.WriteLine("{0}. {1} {2}", i, mgts.FirstName, mgts.LastName);
            }
        }
    }
}
