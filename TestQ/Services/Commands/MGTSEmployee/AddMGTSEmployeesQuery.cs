using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using TestQ.Services.UnitOfWork;

namespace TestQ.Services.Commands.MGTSEmployee
{
    public class AddMGTSEmployeesQuery : ICommand, IAsyncCommand
    {
        private readonly Models.MGTSEmployee _entity;
        public bool RequiresTransaction => false;

        public AddMGTSEmployeesQuery()
        {
            
        }

        public AddMGTSEmployeesQuery(Models.MGTSEmployee entity)
            => _entity = entity;

        private const string Sql = @"INSERT INTO LawsonCompanyCode, LawsonEmployeeCode, MremployeeCode, MpicemployeeCode, MtcemployeeCode, ExchangeLoginId, MgtsloginId, Smtpaddress, LastName, FirstName, " +
                                   @"MiddleInitial, PreferredName, FullName, Extension, PhoneNo, Title, JobCode, HrdeptCode, HrdivisionCode, OfficeCode, CompanyCode, Status, HireDate, TerminationDate" +
                                   @",ActiveFlag, Building,Floor ,Room ,Jack ,TelcoInstrument, TelcoPort,TelcoPair ,ManagerMGTSEmployeeCode ,ManagerLawsonEmployeeCode ,SSN ,ProcessLevel ,SalaryZone" +
                                   @" ,PayGrade ,SexCode ,BirthMonthDay ,Password ,HideFromApplications ,LastLawsonUpdateDateTime ,ExchangeDisplaySuffix ,ExchangeMiddleInitial ,ExchangeExcludeFromExportFlag" +
                                   @" ,MGTSEmployeeFlag1 ,MGTSEmployeeFlag2 ,AdminComment ,AdjHireDate ,JobEffDate,RegionName ,SupervisorLevel ,JobClass ,PreviousLawsonEmployeeCode ,HireSourceCode " +
                                   @" ,SupervisorCompany ,ExemptFlag ,Domain ,RevisionDateTime ,Revisor ,LoginEnabled ,IndirectManager ,Extn ,BusinessTitle ,PublicMobilePhoneNum ,PublicFaxNum" +
                                   @" VALUES (" +
                                   @"@lawsoncompanycode,@lawsonemployeecode,@mremployeecode,@mpicemployeecode,@mtcemployeecode,@exchangeloginid,@mgtsloginid,@smtpaddress,@lastname,@firstname,)" +
                                   @"@middleinitial,@preferredname,@fullname,@extension,@phoneno,@title,@jobcode,@hrdeptcode,@hrdivisioncode,@officecode,@companycode,@status,@hiredate,@terminationdate" +
                                   @",@activeflag,@building,@floor,@room,@jack,@telcoinstrument,@telcoport,@telcopair,@managermgtsemployeecode,@managerlawsonemployeecode,@ssn,@processlevel,@salaryzone" +
                                   @",@paygrade,@sexcode,@birthmonthday,@password,@hidefromapplications,@lastlawsonupdatedatetime,@exchangedisplaysuffix,@exchangemiddleinitial,@exchangeexcludefromexportflag" +
                                   @",@mgtsemployeeflag1,@mgtsemployeeflag2,@admincomment,@adjhiredate,@jobeffdate,@regionname,@supervisorlevel,@jobclass,@previouslawsonemployeecode,@hiresourcecode " +
                                   @",@supervisorcompany,@exemptflag,@domain,@revisiondatetime,@revisor,@loginenabled,@indirectmanager,@extn,@businesstitle,@publicmobilephonenum,@publicfaxnum";

        public void Execute(IDbConnection connection, IDbTransaction transaction)
         => connection.ExecuteAsync(Sql, new
        {
            lawsoncompanycode = _entity.LawsonCompanyCode,
            lawsonemployeecode = _entity.LawsonEmployeeCode,
            mremployeecode = _entity.MremployeeCode,
            mpicemployeecode = _entity.MpicemployeeCode,
            mtcemployeecode = _entity.MtcemployeeCode,
            exchangeloginid = _entity.ExchangeLoginId,
            mgtsloginid = _entity.MgtsloginId,
            smtpaddress = _entity.Smtpaddress,
            lastname = _entity.LastName,
            firstname = _entity.FirstName,
            middleinitial = _entity.MiddleInitial,
            preferredname = _entity.PreferredName,
            fullname = _entity.FullName,
            extension = _entity.Extension,
            phoneno = _entity.PhoneNo,
            title = _entity.Title,
            jobcode = _entity.JobCode,
            hrdeptcode = _entity.HrdeptCode,
            hrdivisioncode = _entity.HrdivisionCode,
            officecode = _entity.OfficeCode,
            companycode = _entity.CompanyCode,
            status = _entity.Status,
            hiredate = _entity.HireDate,
            terminationdate = _entity.TerminationDate,
            activeflag = _entity.ActiveFlag,
            building = _entity.Building,
            floor = _entity.Floor,
            room = _entity.Room,
            jack = _entity.Jack,
            telcoinstrument = _entity.TelcoInstrument,
            telcoport = _entity.TelcoPort,
            telcopair = _entity.TelcoPair,
            managermgtsemployeecode = _entity.ManagerMgtsemployeeCode,
            managerlawsonemployeecode = _entity.ManagerLawsonEmployeeCode,
            ssn = _entity.Ssn,
            processlevel = _entity.ProcessLevel,
            salaryzone = _entity.SalaryZone,
            paygrade = _entity.PayGrade,
            sexcode = _entity.SexCode,
            birthmonthday = _entity.BirthMonthDay,
            password = _entity.Password,
            hidefromapplications = _entity.HideFromApplications,
            lastlawsonupdatedatetime = _entity.LastLawsonUpdateDateTime,
            exchangedisplaysuffix = _entity.ExchangeDisplaySuffix,
            exchangemiddleinitial = _entity.ExchangeMiddleInitial,
            exchangeexcludefromexportflag = _entity.ExchangeExcludeFromExportFlag,
            mgtsemployeeflag1 = _entity.MgtsemployeeFlag1,
            mgtsemployeeflag2 = _entity.MgtsemployeeFlag2,
            admincomment = _entity.AdminComment,
            adjhiredate = _entity.AdjHireDate,
            jobeffdate = _entity.JobEffDate,
            regionname = _entity.RegionName,
            supervisorlevel = _entity.SupervisorLevel,
            jobclass = _entity.JobClass,
            previouslawsonemployeecode = _entity.PreviousLawsonEmployeeCode,
            hiresourcecode = _entity.HireSourceCode,
            supervisorcompany = _entity.SupervisorCompany,
            exemptflag = _entity.ExemptFlag,
            domain = _entity.Domain,
            revisiondatetime = _entity.RevisionDateTime,
            revisor = _entity.Revisor,
            loginenabled = _entity.LoginEnabled,
            indirectmanager = _entity.IndirectManager,
            extn = _entity.Extn,
            businesstitle = _entity.BusinessTitle,
            publicmobilephonenum = _entity.PublicMobilePhoneNum,
            publicfaxnum = _entity.PublicFaxNum
    }, transaction);

        public async Task ExecuteAsync(IDbConnection connection, IDbTransaction transaction, CancellationToken cancellationToken = default)
        => await connection.ExecuteAsync(Sql, new
        {
            lawsoncompanycode = _entity.LawsonCompanyCode,
            lawsonemployeecode = _entity.LawsonEmployeeCode,
            mremployeecode = _entity.MremployeeCode,
            mpicemployeecode = _entity.MpicemployeeCode,
            mtcemployeecode = _entity.MtcemployeeCode,
            exchangeloginid = _entity.ExchangeLoginId,
            mgtsloginid = _entity.MgtsloginId,
            smtpaddress = _entity.Smtpaddress,
            lastname = _entity.LastName,
            firstname = _entity.FirstName,
            middleinitial = _entity.MiddleInitial,
            preferredname = _entity.PreferredName,
            fullname = _entity.FirstName + " " + _entity.MiddleInitial + " " + _entity.LastName,
            extension = _entity.Extension,
            phoneno = _entity.PhoneNo,
            title = _entity.Title,
            jobcode = _entity.JobCode,
            hrdeptcode = _entity.HrdeptCode,
            hrdivisioncode = _entity.HrdivisionCode,
            officecode = _entity.OfficeCode,
            companycode = _entity.CompanyCode,
            status = _entity.Status,
            hiredate = _entity.HireDate,
            terminationdate = _entity.TerminationDate,
            activeflag = _entity.ActiveFlag,
            building = _entity.Building,
            floor = _entity.Floor,
            room = _entity.Room,
            jack = _entity.Jack,
            telcoinstrument = _entity.TelcoInstrument,
            telcoport = _entity.TelcoPort,
            telcopair = _entity.TelcoPair,
            managermgtsemployeecode = _entity.ManagerMgtsemployeeCode,
            managerlawsonemployeecode = _entity.ManagerLawsonEmployeeCode,
            ssn = _entity.Ssn,
            processlevel = _entity.ProcessLevel,
            salaryzone = _entity.SalaryZone,
            paygrade = _entity.PayGrade,
            sexcode = _entity.SexCode,
            birthmonthday = _entity.BirthMonthDay,
            password = _entity.Password,
            hidefromapplications = _entity.HideFromApplications,
            lastlawsonupdatedatetime = _entity.LastLawsonUpdateDateTime,
            exchangedisplaysuffix = _entity.ExchangeDisplaySuffix,
            exchangemiddleinitial = _entity.ExchangeMiddleInitial,
            exchangeexcludefromexportflag = _entity.ExchangeExcludeFromExportFlag,
            mgtsemployeeflag1 = _entity.MgtsemployeeFlag1,
            mgtsemployeeflag2 = _entity.MgtsemployeeFlag2,
            admincomment = _entity.AdminComment,
            adjhiredate = _entity.AdjHireDate,
            jobeffdate = _entity.JobEffDate,
            regionname = _entity.RegionName,
            supervisorlevel = _entity.SupervisorLevel,
            jobclass = _entity.JobClass,
            previouslawsonemployeecode = _entity.PreviousLawsonEmployeeCode,
            hiresourcecode = _entity.HireSourceCode,
            supervisorcompany = _entity.SupervisorCompany,
            exemptflag = _entity.ExemptFlag,
            domain = _entity.Domain,
            revisiondatetime = _entity.RevisionDateTime,
            revisor = _entity.Revisor,
            loginenabled = _entity.LoginEnabled,
            indirectmanager = _entity.IndirectManager,
            extn = _entity.Extn,
            businesstitle = _entity.BusinessTitle,
            publicmobilephonenum = _entity.PublicMobilePhoneNum,
            publicfaxnum = _entity.PublicFaxNum
        }, transaction);

    }
}
