using System;
using MongoDB.Driver;

namespace Rebus.MongoDb
{
    /// <summary>
    /// [UPGRADE mongocsharpdriver to 2.x]
    /// In the old version of the driver, there was an exception called 'WriteConcernException'.
    /// In the new version, it has been replaced by MongoWriteConcernException.
    /// This last one requires in a constructor a parameter (connectionId)
    /// that we don't have when we manually throw this kind of exception.
    /// For this reason, we created MongoWriteConcernExceptionEx.
    /// </summary>
    public class MongoWriteConcernExceptionEx : Exception
    {
        public string ExceptionMessage { get; private set; }
        public WriteConcernResult WriteConcernResult { get; private set; }

        public MongoWriteConcernExceptionEx(string exceptionMessage, WriteConcernResult writeConcernResult)
        {
            ExceptionMessage = exceptionMessage;
            WriteConcernResult = writeConcernResult;
        }
    }
}