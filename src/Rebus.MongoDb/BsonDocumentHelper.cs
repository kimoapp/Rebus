using MongoDB.Bson;

namespace Rebus.MongoDb
{
    internal static class BsonDocumentHelper
    {
        /// <summary>
        /// [UPGRADE mongocsharpdriver to 2.x]
        /// In the previous version of BsonDocument, when we tried to add a null value
        /// using the method 'add', it was automatically skipped (the field
        /// wasn't created in the document).
        /// In the new version, we have to do it explicitly.
        /// </summary>
        public static BsonDocument AddIfNotNull(this BsonDocument doc, string name, object value)
        {
            if (value != null) {
                doc.Add(name, BsonValue.Create(value));
            }
            return doc;
        }
    }
}
