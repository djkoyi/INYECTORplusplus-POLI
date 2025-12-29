namespace INYECTOR.clases
{
    using System.Data.SqlClient;
    using System.Data;
    using System;
    using INYECTOR.clases;
    public class gDatos
    {
        #region Conexion Base de Datos
        public SqlConnection Cn = new SqlConnection("Server=PC963446;Initial Catalog=RelojPoliclinica;Persist Security Info=True;User " +
            "ID=SoporteVeraguas;Password=sqlveraguas;Encrypt=False");
        #endregion
        #region Poner Parametros
        private static System.Collections.Hashtable mColComandos = new System.Collections.Hashtable();
        protected IDbCommand Comando(string ProcedimientoAlmacenado)
        {
            SqlCommand mComando = null;
            if (mColComandos.Contains(ProcedimientoAlmacenado))
            {
                mComando = (SqlCommand)mColComandos[ProcedimientoAlmacenado];
            }
            else
            {
                Cn.Open();
                mComando = new SqlCommand(ProcedimientoAlmacenado, Cn);
                SqlCommandBuilder mContructor = new SqlCommandBuilder();
                mComando.Connection = Cn;
                mComando.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(mComando);
                Cn.Close();
                mColComandos.Add(ProcedimientoAlmacenado, mComando);
            }
            return mComando;
        }
        protected void CargarParametros(IDbCommand Comando, object[] Args)
        {
            int I = 0;
            for (I = 0; I <= Args.GetUpperBound(0); I++)
            {
                try
                {
                    ((SqlParameter)Comando.Parameters[I + 1]).Value = Args[I];
                }
                catch (Exception Qex)
                {
                    throw Qex;
                }
            }
        }
        #endregion
        #region Devolver Parametros
        protected IDataAdapter CrearDataAdapter(string ProcedimientoAlmacenado, params object[] Args)
        {
            SqlCommand mCom = (SqlCommand)Comando(ProcedimientoAlmacenado);
            if (Args != null)
            {
                CargarParametros(mCom, Args);
            }
            return new SqlDataAdapter(mCom);
        }
        //En este caso trabajaremos con funciones sobrecargadas con la finalidad de poder llamar a la ‘misma function pero con diferentes parametros. 
        public DataSet TraerDataset(string ProcedimientoAlmacenado)
        {
            DataSet mDataset = new DataSet();
            CrearDataAdapter(ProcedimientoAlmacenado).Fill(mDataset);
            return mDataset;
        }
        //Funcion Sobrecargada 
        public DataSet TraerDataset(string ProcedimientoAlmacenado, params object[] Argumentos)
        {
            DataSet mDataset = new DataSet();
            CrearDataAdapter(ProcedimientoAlmacenado, Argumentos).Fill(mDataset);
            return mDataset;
        }
        #endregion
        #region Acciones
        public int Ejecutar(string ProcedimientoAlmacenado, params object[] Argumentos)
        {
            SqlCommand mCom = (SqlCommand)Comando(ProcedimientoAlmacenado);
            int Resp = 0;
            Cn.Open();
            mCom.Connection = Cn;
            mCom.CommandType = CommandType.StoredProcedure;
            CargarParametros(mCom, Argumentos);
            Resp = mCom.ExecuteNonQuery();
            Cn.Close();
            return Resp;
        }
        #endregion
    }

}
