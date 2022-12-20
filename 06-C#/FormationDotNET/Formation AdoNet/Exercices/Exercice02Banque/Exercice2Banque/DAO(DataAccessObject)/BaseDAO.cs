using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2Banque.DAO_DataAccessObject_
{
    internal abstract class BaseDAO<T>
    {
        protected static SqlCommand _command;
        protected static SqlConnection _connection;
        protected static SqlDataReader _reader;
        protected static string _request;

        public abstract int Create(T element);

        public abstract int Delete(T element);

        public abstract int Update(T element);

        public abstract T Find(int index);

        public abstract List<T> Find(Func<T,bool> criteria);

        public abstract List<T> FindAll();

    }
}
