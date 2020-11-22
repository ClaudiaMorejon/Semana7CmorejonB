using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Semana7CmorejonB.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
[assembly:Xamarin.Forms.Dependency(typeof(SqliteClient))]

namespace Semana7CmorejonB.Droid
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