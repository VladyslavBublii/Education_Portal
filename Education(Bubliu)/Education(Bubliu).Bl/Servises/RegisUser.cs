using Education_Bubliu_.Bl.DTO;
using Education_Bubliu_.Bl.Mappers;
using Education_Bubliu_.Core.Entities;
using System;
using static Education_Bubliu_.Bl.Servises.ValidPass;
using Education_Bubliu_.DAL.EF.Repos;

namespace Education_Bubliu_.Bl.Servises
{
    public class RegisUser
    {
        public bool Registration(InfoUserDTO userDTO)
        {
            ValidEmail email = new ValidEmail();

            Strength MediumPass;
            MediumPass = Strength.Medium;
            ValidPass PassСheck = new ValidPass();


            UsersRegMap userRegMap = new UsersRegMap();
            var mapper = userRegMap.GetUserMapper();
            var user=mapper.Map<InfoUserDTO, Users>(userDTO);


            if ((email.ValideEmail(userDTO.Email)) && ((PassСheck.PasswordStrength(userDTO.PassWord)) > MediumPass))
            {
                Console.WriteLine("RegisUser in BLS");
                using (UserContext db = new UserContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }

                return true;
            }
            else
            {
                Console.WriteLine("invalide Email");
                return false;
            }

        }
    }
}
