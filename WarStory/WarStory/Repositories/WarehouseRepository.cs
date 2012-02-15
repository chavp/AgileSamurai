using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WarStory.Models;

using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace WarStory.Repositories
{
    public class WarehouseRepository
    {
        string _conectionString;
        public WarehouseRepository(string conectionString)
        {
            _conectionString = conectionString;
        }

        public Warehouse Save(string name)
        {
            var server = MongoServer.Create(_conectionString);
            var warstoryDocuments = server.GetDatabase("warstory-documents");
            Warehouse warehouseDocument = null;
            using (server.RequestStart(warstoryDocuments))
            {
                
                var warehouseDocuments = warstoryDocuments.GetCollection<Warehouse>("warehouse-documents");
                var query = Query.EQ("_id", name);

                warehouseDocument = warehouseDocuments.FindAs<Warehouse>(query).SingleOrDefault();
                if (warehouseDocument != null)
                {
                    warehouseDocument.Action();
                    warehouseDocuments.Save<Warehouse>(warehouseDocument);
                }
                else
                {
                    warehouseDocument = new Warehouse { Name = "Chavp" };
                    warehouseDocuments.Save<Warehouse>(warehouseDocument);
                }
            }

            return warehouseDocument;
        }
    }
}