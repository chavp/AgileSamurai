using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using WarStoryServer.Repositories;

namespace WarStoryServer
{
    public class TheWarStory
    {
        WarehouseRepository _WarehouseRepository;
        public TheWarStory()
        {
            _WarehouseRepository = new WarehouseRepository("mongodb://localhost");
        }

        
        public void Next()
        {
            Console.Write(".");
            _WarehouseRepository.Update();
        }
    }
}
