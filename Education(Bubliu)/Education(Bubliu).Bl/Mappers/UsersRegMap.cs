using AutoMapper;
using Education_Bubliu_.Bl.DTO;
using Education_Bubliu_.Core.Entities;


namespace Education_Bubliu_.Bl.Mappers
{
    public class UsersRegMap
    {
        public MapperConfiguration MapperConfiguration()
        {

            return new MapperConfiguration(c => c.CreateMap<InfoUserDTO, Users>()
            .ForMember(z => z.Name,
            z => z.MapFrom(m => m.Name))
            .ForMember(z => z.Email,
            z => z.MapFrom(m => m.Email))
            .ForMember(z => z.Sex,
            z => z.MapFrom(m => m.Sex))
            .ForMember(z => z.Password,
            z => z.MapFrom(m => m.PassWord)));
        }
        public Mapper GetUserMapper()
        {
            return new Mapper(MapperConfiguration());
        }
    }
}
