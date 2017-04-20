using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanager
{
    class idmanager
    {
        private static int nextcityid = 0;
        private static int nextstoreid = 0;
        private static int nextstoretype = 0;
        private static int nextinventoryid = 0;
        private static int nextItem = 0;
        private static int nextWorker = 0;
        public static int getNextCityId()
        {
            return nextcityid++;
        }
        public static int getNextStoreId()
        {
            return nextstoreid++;
        }
        public static int getNextTypeId()
        {
            return nextstoretype++;
        }
        public static int getNextInvId()
        {
            return nextinventoryid++;
        }
        public static int getNextItemId()
        {
            return nextWorker++;
        }
        public static int getNextWorkerId()
        {
            return nextItem++;
        }
        public static void InitInvId()
        {
            inventoryEntities test = new inventoryEntities();
            var load = from g in test.stores select g.inventoryid;
            if (load != null)
            {
                if (load.Any())
                {
                    nextinventoryid = load.Max() + 1;
                }
                else
                    nextinventoryid = 0;
            }
            var load2 = from g in test.stores select g.cityid;
            if (load2 != null)
            {
                if (load2.Any())
                {
                    nextcityid = load2.Max() + 1;
                }
                else
                    nextcityid = 0;
            }
            var load3 = from g in test.stores select g.storeID;
            if (load3 != null)
            {
                if (load3.Any())
                {
                    nextstoreid = load3.Max() + 1;
                }
                else
                    nextstoreid = 0;
            }
            var load4 = from g in test.stores select g.StoreType;
            if (load4 != null)
            {
                if (load4.Any())
                {
                    nextstoretype = load4.Max() + 1;
                }
                else
                    nextstoretype = 0;
            }
            var load5 = from g in test.items select g.itemid;
            if (load5 != null)
            {
                if (load5.Any())
                {
                    nextItem = load5.Max() + 1;
                }
                else
                    nextItem = 0;
            }
            var load6 = from g in test.workers select g.workerid;
            if (load6 != null)
            {
                if (load6.Any())
                {
                    nextWorker = load6.Max() + 1;
                }
                else
                    nextWorker = 0;
            }
        }
    }
}
