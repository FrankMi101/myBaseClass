// <copyright file="DataTest.cs" company="TCDSB">Copyright © TCDSB 2009</copyright>
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myCommon;

namespace myCommon.Tests
{
    /// <summary>This class contains parameterized unit tests for Data</summary>
    [PexClass(typeof(global::myCommon.Data))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DataTest
    {
        /// <summary>Test stub for SaveData(String, MyParameter[])</summary>
        [PexMethod]
        public void SaveDataTest(string _SP, MyParameter[] _Para)
        {
            Data.SaveData(_SP, _Para);
            // TODO: add assertions to method DataTest.SaveDataTest(String, MyParameter[])
        }

        /// <summary>Test stub for SetParameter(IDbCommand, String, DbType, Int32, Object)</summary>
        [PexMethod]
        public IDbDataParameter SetParameterTest(
            IDbCommand cmd,
            string pName,
            DbType pType,
            int pSize,
            object pValue
        )
        {
            IDbDataParameter result
               = global::myCommon.Data.SetParameter(cmd, pName, pType, pSize, pValue);
            return result;
            // TODO: add assertions to method DataTest.SetParameterTest(IDbCommand, String, DbType, Int32, Object)
        }

        /// <summary>Test stub for get_dbConnectingSTR()</summary>
        [PexMethod]
        public string dbConnectingSTRGetTest()
        {
            string result = Data.dbConnectingSTR;
            return result;
            // TODO: add assertions to method DataTest.dbConnectingSTRGetTest()
        }

        /// <summary>Test stub for myBool(String, MyParameter[])</summary>
        [PexMethod]
        public bool myBoolTest(string _SP, MyParameter[] _Para)
        {
            bool result = Data.myBool(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myBoolTest(String, MyParameter[])
        }

        /// <summary>Test stub for myBool(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public bool myBoolTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            bool result = Data.myBool(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myBoolTest01(String, MyParameter[], Int16)
        }

        /// <summary>Test stub for myByte(String, MyParameter[])</summary>
        [PexMethod]
        public byte myByteTest(string _SP, MyParameter[] _Para)
        {
            byte result = Data.myByte(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myByteTest(String, MyParameter[])
        }

        /// <summary>Test stub for myByte(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public byte myByteTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            byte result = Data.myByte(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myByteTest01(String, MyParameter[], Int16)
        }

        /// <summary>Test stub for myDataListObj(String, MyParameter[], Int16, Object)</summary>
        [PexMethod]
        public object myDataListObjTest(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut,
            object myListObj
        )
        {
            object result = Data.myDataListObj(_SP, _Para, _TimeOut, myListObj);
            return result;
            // TODO: add assertions to method DataTest.myDataListObjTest(String, MyParameter[], Int16, Object)
        }

        /// <summary>Test stub for myDataList(String, MyParameter[])</summary>
        [PexMethod]
        public IList<MyList> myDataListTest(string _SP, MyParameter[] _Para)
        {
            IList<MyList> result = Data.myDataList(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myDataListTest(String, MyParameter[])
        }

        /// <summary>Test stub for myDataList(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public IList<MyList> myDataListTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            IList<MyList> result = Data.myDataList(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myDataListTest01(String, MyParameter[], Int16)
        }

        /// <summary>Test stub for myDataReader(String, MyParameter[])</summary>
        [PexMethod]
        public IDataReader myDataReaderTest(string _SP, MyParameter[] _Para)
        {
            IDataReader result = global::myCommon.Data.myDataReader(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myDataReaderTest(String, MyParameter[])
        }

        /// <summary>Test stub for myDataReader(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public IDataReader myDataReaderTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            IDataReader result = global::myCommon.Data.myDataReader(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myDataReaderTest01(String, MyParameter[], Int16)
        }

        /// <summary>Test stub for myDataSet(String, MyParameter[])</summary>
        [PexMethod]
        public DataSet myDataSetTest(string _SP, MyParameter[] _Para)
        {
            DataSet result = global::myCommon.Data.myDataSet(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myDataSetTest(String, MyParameter[])
        }

        /// <summary>Test stub for myDataSet(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public DataSet myDataSetTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            DataSet result = global::myCommon.Data.myDataSet(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myDataSetTest01(String, MyParameter[], Int16)
        }

        /// <summary>Test stub for myDataTable(String, MyParameter[])</summary>
        [PexMethod]
        public DataTable myDataTableTest(string _SP, MyParameter[] _Para)
        {
            DataTable result = global::myCommon.Data.myDataTable(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myDataTableTest(String, MyParameter[])
        }

        /// <summary>Test stub for myDataTable(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public DataTable myDataTableTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            DataTable result = global::myCommon.Data.myDataTable(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myDataTableTest01(String, MyParameter[], Int16)
        }

        /// <summary>Test stub for myDateTime(String, MyParameter[])</summary>
        [PexMethod]
        public DateTime myDateTimeTest(string _SP, MyParameter[] _Para)
        {
            DateTime result = Data.myDateTime(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myDateTimeTest(String, MyParameter[])
        }

        /// <summary>Test stub for myDateTime(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public DateTime myDateTimeTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            DateTime result = Data.myDateTime(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myDateTimeTest01(String, MyParameter[], Int16)
        }

        /// <summary>Test stub for get_myDbConnection()</summary>
        [PexMethod]
        public IDbConnection myDbConnectionGetTest()
        {
            IDbConnection result = global::myCommon.Data.myDbConnection;
            return result;
            // TODO: add assertions to method DataTest.myDbConnectionGetTest()
        }

        /// <summary>Test stub for myReaderObject(String, MyParameter[], Int16, String)</summary>
        [PexMethod]
        public object myReaderObjectTest(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut,
            string dataType
        )
        {
            object result = Data.myReaderObject(_SP, _Para, _TimeOut, dataType);
            return result;
            // TODO: add assertions to method DataTest.myReaderObjectTest(String, MyParameter[], Int16, String)
        }

        /// <summary>Test stub for myValue(String, MyParameter[])</summary>
        [PexMethod]
        public string myValueTest(string _SP, MyParameter[] _Para)
        {
            string result = Data.myValue(_SP, _Para);
            return result;
            // TODO: add assertions to method DataTest.myValueTest(String, MyParameter[])
        }

        /// <summary>Test stub for myValue(String, MyParameter[], Int16)</summary>
        [PexMethod]
        public string myValueTest01(
            string _SP,
            MyParameter[] _Para,
            short _TimeOut
        )
        {
            string result = Data.myValue(_SP, _Para, _TimeOut);
            return result;
            // TODO: add assertions to method DataTest.myValueTest01(String, MyParameter[], Int16)
        }
    }
}
