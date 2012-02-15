using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WarStory.Domain;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace WarStoryServer.Repositories
{
    public class WarehouseRepository
    {
        string _conectionString;
        MongoServer _server;

        public WarehouseRepository(string conectionString)
        {
            _conectionString = conectionString;
            _server = MongoServer.Create(_conectionString);

        }

        public Warehouse Save(string name)
        {
            var warstoryDocuments = _server.GetDatabase("warstory-documents");
            Warehouse warehouseDocument = null;
            using (_server.RequestStart(warstoryDocuments))
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
        public Warehouse Save(Warehouse warehouse)
        {
            var warstoryDocuments = _server.GetDatabase("warstory-documents");
            using (_server.RequestStart(warstoryDocuments))
            {

                var warehouseDocuments = warstoryDocuments.GetCollection<Warehouse>("warehouse-documents");
                warehouseDocuments.Save<Warehouse>(warehouse);
            }

            return warehouse;
        }

        public void Update()
        {
            var warstoryDocuments = _server.GetDatabase("warstory-documents");

            using (_server.RequestStart(warstoryDocuments))
            {

                var warehouseDocuments = warstoryDocuments.GetCollection<Warehouse>("warehouse-documents");
                
                var warehouseList = warehouseDocuments.FindAllAs<Warehouse>().ToList();
                warehouseList.ForEach(w =>
                {
                    Console.WriteLine("Update: " + w.Updated);
                    w.Action();
                    warehouseDocuments.Save<Warehouse>(w);
                });


            }
        }
    }
}
