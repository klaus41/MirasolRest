using MirasolDAL.DomainModel;
using MirasolDTO.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirasolDTO.Converters
{
    public class ApartmentConverter : AbstractDtoConverter<Apartment, ApartmentDTO>
    {
        public override ApartmentDTO Convert(Apartment item)
        {
            var dto = new ApartmentDTO()
            {
                
            };

            return dto;
        }
    }
}
