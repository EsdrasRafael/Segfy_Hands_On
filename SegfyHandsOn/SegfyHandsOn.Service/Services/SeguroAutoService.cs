﻿using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Domain.Interfaces;
using SegfyHandsOn.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SegfyHandsOn.Service.Services
{
    public class SeguroAutoService : BaseServiceIService<SeguroAuto>
    {
        private readonly SeguroAutoRepository seguroAutoRepository;
        public SeguroAutoService(SeguroAutoRepository _seguroAutoRepository) : base(_seguroAutoRepository)
        {
            seguroAutoRepository = _seguroAutoRepository;
        }
    }
}
