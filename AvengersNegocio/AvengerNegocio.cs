using AvengerRepositorio;
using AvengersModelo;
using System;
using System.Collections.Generic;

namespace AvengersNegocio
{
    public class AvengerNegocio
    {
        private AvengerRepository _avengerRepository = new AvengerRepository();

        public IEnumerable<AvengersModel> Get()
        {
            return _avengerRepository.Get();
        }

        public bool Delete()
        {
            return _avengerRepository.Delete();
        }


    }
}
