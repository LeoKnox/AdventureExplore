﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureExplore.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string Description { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public virtual ICollection<Door> Doors { get; set; }
    }

    public class Door
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoorId { get; set; }
        public string Material { get; set; }
        public int Wall { get; set; }
        public int Position { get; set; }
    }
}
