using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    [Table("PlayerItems")]
    public class PlayerItem
    {
        [Key]
        public int InventoryId { get; set; }
        public int PlayerId { get; set; }
        public int ItemId { get; set; }
        public Player Player { get; set; }
        public Item Item { get; set; }


    }
}