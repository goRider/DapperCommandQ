using System;
using System.Threading.Tasks;
using TestQ.Models;
using TestQ.Services.Commands.MGTSEmployee;
using TestQ.Services.UnitOfWork;

namespace TestQ
{
    class Program
    {
        private const string ConnectionString =
            @"Server=DESKTOP-U64RJVE\SQLEXPRESS;Database=FakeIgn;Trusted_Connection=True;MultipleActiveResultSets=true";

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
            Program.


            Console.WriteLine("Hello World!");
        }
    }
}
