using System;
using System.Collections.Generic;
using System.Linq;
using SERVICE.Models;
using SERVICE.Dtos;

namespace SERVICE
{
    public class KTNService : IKTNService
    {
        /// <summary>
        ///     Olke, Sheher, Kendlerin siyahisini goturur
        /// </summary>
        /// <param name="type"></param>
        /// <returns>List<RegionDto></returns>
        public List<RegionDto> GetRegions(RegionsType type)
        {
            using (var db = new ServiceModel())
            {
                try
                {
                    var regions = db.REGIONS.Where(r => r.LEVEL == (int)type).Select(r =>
                        new RegionDto
                        {
                            ID = r.ID,
                            REGION_NAME = r.REGION_NAME,
                            P_ID = r.P_ID
                        }
                    ).ToList();

                    return regions;
                }
                catch
                {
                    return null;
                }
            }
        }


        /// <summary>
        /// Vetendaslarin siyahisini bazadan aliriq. (numune oldugu ucun cox derine getmemisem)
        /// Burda filterlerde ola bilerdi. Pagination ola biler ve sair.
        /// </summary>
        /// <returns>List<PersonDto></returns>
        public List<PersonDto> GetPersons()
        {
            using (var db = new ServiceModel())
            {
                try
                {
                    var persons = db.CITIZENS.Select(p =>
                        new PersonDto
                        {
                            ID = p.ID,
                            FIRST_NAME = p.FIRST_NAME,
                            LAST_NAME = p.LAST_NAME,
                            REGION = new RegionDto
                            {
                                ID = p.REGION.ID,
                                REGION_NAME = p.REGION.REGION_NAME,
                                P_ID = p.REGION.P_ID
                            }

                        }
                    ).ToList();

                    return persons;
                }
                catch
                {
                    return null;
                }
            }
        }


        public UserDto GetUser(string username, string password)
        {
            using (var db = new ServiceModel())
            {
                try
                {
                    var user = db.USERS.Where(u => u.USERNAME.Contains(username) && u.PASSWORD == password).Select(u => new UserDto
                    {
                        ID = u.ID,
                        USERNAME = u.USERNAME,
                        FIRST_NAME = u.FIRST_NAME,
                        LAST_NAME = u.LAST_NAME
                    }).FirstOrDefault();

                    return user;
                }
                catch(Exception e)
                {
                    return null;
                }
            }
        }

        public UserDto GetUserByUsername(string username)
        {
            using (var db = new ServiceModel())
            {
                try
                {
                    var user = db.USERS.Where(u => u.USERNAME.Contains(username)).Select(u => new UserDto
                    {
                        ID = u.ID,
                        USERNAME = u.USERNAME,
                        FIRST_NAME = u.FIRST_NAME,
                        LAST_NAME = u.LAST_NAME
                    }).FirstOrDefault();

                    return user;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }




    public enum RegionsType
    {
        COUNTRIES,
        CITIES,
        DISTRICTS
    }
}
