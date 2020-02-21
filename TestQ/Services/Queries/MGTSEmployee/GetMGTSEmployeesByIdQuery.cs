using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using TestQ.Services.UnitOfWork;

namespace TestQ.Services.Queries.MGTSEmployee
{
    public class GetMGTSEmployeesByIdQuery : IQuery<Models.MGTSEmployee>, IAsyncQuery<Models.MGTSEmployee>
    {
        private const string _sql = @"
			SELECT
				MgtsemployeeCode
			FROM
				ign.MGTSEmployee
			WHERE
				MgtsemployeeCode = @mgtsemployeecode
		";

        private readonly int _employeeCode;

        public GetMGTSEmployeesByIdQuery(int employeeCode)
        {
            _employeeCode = employeeCode;
        }

        public Models.MGTSEmployee Execute(IDbConnection connection, IDbTransaction transaction)
            => connection.Query<Models.MGTSEmployee>(_sql, new
            {
                MgtsemployeeCode = _employeeCode
            }, transaction).FirstOrDefault();

        public async Task<Models.MGTSEmployee> ExecuteAsync(IDbConnection connection, IDbTransaction transaction,
            CancellationToken cancellationToken = default)
            => await connection.QueryFirstOrDefaultAsync<Models.MGTSEmployee>(_sql, new
            {
                MgtsemployeeCode = _employeeCode
            }, transaction);

    }
}
