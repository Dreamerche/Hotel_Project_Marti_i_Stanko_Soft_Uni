using Hotel_Project_Marti_i_Stanko.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Project_Marti_i_Stanko.Models
{
    public class Room
    {
        public int ID { get; set; }
        public int capacity { get; set; }

        [Column("RoomType")]
        public string roomType { get; set; }

        public void SetType(RoomType roomType1)
        {
            roomType = roomType1.ToString();
        }
        public bool isOccupied { get; set; }
        public double priceForAdult { get; set; }
        public double priceForChild { get; set; }
        public int number { get; set; }
    }
}
