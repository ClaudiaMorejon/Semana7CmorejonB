using Foundation;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Semana7CmorejonB.iOS;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

using UIKit;
[assembly: Xamarin.Forms.Dependency(typeof(SqliteClient))]

namespace Semana7CmorejonB.iOS
{
    public class SqliteClient : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentspath, "uisrael.db");
            return new SQLiteAsyncConnection(path);
        }

        
    }
}