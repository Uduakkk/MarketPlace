using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MarketPlace.Core.Interfaces.Repositories
{
    public interface IDapperContext
    {
        IDbConnection GetDbConnection();
        IDbConnection GetAuthServiceDbConnection();

    }
}
