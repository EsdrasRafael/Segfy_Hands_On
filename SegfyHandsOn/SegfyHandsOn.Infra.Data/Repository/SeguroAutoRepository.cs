using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Infra.Data.Repository
{
    public class SeguroAutoRepository : BaseRepository<SeguroAuto>
    {
        private MySqlContext mysqlContext;
        public SeguroAutoRepository(MySqlContext _mysqlContext) : base(_mysqlContext)
        {
            mysqlContext = _mysqlContext;
        }
    }
}
