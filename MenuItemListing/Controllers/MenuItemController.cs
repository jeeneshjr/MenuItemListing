using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
       public static List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {
                Id=1, 
                Name="Keyboard", 
                Active=true, 
                DateOfLaunch=new DateTime(2022,06,01), 
                FreeDelivery=false,Price=1500},

                new MenuItem() {
                    Id=2, 
                    Name="Mouse", 
                    Active=false, 
                    DateOfLaunch=new DateTime(2022,06,03), 
                    FreeDelivery=false,Price=800}

            };

        [HttpGet]
        public List<MenuItem> GetItem()
        {
            
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
        }
    }
}
