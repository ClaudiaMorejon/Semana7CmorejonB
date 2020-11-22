using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Semana7CmorejonB
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
        
    }
}
