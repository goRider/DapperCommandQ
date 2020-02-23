using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RandomNameGeneratorLibrary;
using TestQ.Models;

namespace TestQ.DbSeedGenerator
{
    public class UserAttributeValue
    {
        private List<string> _firstNames;
        private List<MGTSEmployee> _mgtsList;
        private List<string> _lwCode;
        private int _id;

        public string CreateRandomFirstNames(List<string> finalFirstNameList)
        {
            Random random = new Random();
            var rndCounter = random.Next(-1, finalFirstNameList.Count + 1);
            var finalFirstName = finalFirstNameList[rndCounter];
            return finalFirstName;
        }

        public string CreateRandomLastNames(List<string> lastNameList)
        {
            Random random = new Random();
            var rndCounter = random.Next(-1, lastNameList.Count + 1);
            var finalFirstName = lastNameList[rndCounter];
            return finalFirstName;
        }

        public void AddMaleEmpAttributes(int seedCount, int nameCount, int iterationCount)
        {
            Random rand = new Random(seedCount);
            var genMales = new PersonNameGenerator(rand);
            var firstNameList = genMales.GenerateMultipleMaleFirstNames(nameCount).ToList();
            var lastNameList = genMales.GenerateMultipleLastNames(nameCount).ToList();
            _id = 0;
            var mgts = new MGTSEmployee();
            _mgtsList = new List<MGTSEmployee>();
            _lwCode = new List<string> { "1000", "0001" };
            Random lwRandom = new Random();
            int lwSeed = lwRandom.Next(2);

            for (int i = 0; i < iterationCount; i++)
            {
                //mgts.MgtsemployeeCode = 
                mgts.FirstName = firstNameList[i];
                mgts.LastName = lastNameList[i];
                mgts.FullName = firstNameList[i] + " " + lastNameList[i];
                mgts.LawsonCompanyCode = _lwCode[lwSeed];
                _mgtsList.Add(mgts);
                _id += i;

                // See output for test purposes


                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", _id, mgts.FirstName, mgts.LastName, mgts.FullName, mgts.LawsonCompanyCode);

                //if (mgts.LawsonCompanyCode == "0001")
                //{
                //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}", _id, mgts.FirstName, mgts.LastName, mgts.FullName, mgts.LawsonCompanyCode);
                //}
                
            }
        }

        public void AddFemaleEmpAttributes(int seedCount, int nameCount, int iterationCount)
        {
            Random rand = new Random(seedCount);
        }
    }
}
