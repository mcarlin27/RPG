using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public byte[] Avatar { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int LocationId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual List<PlayerItem> PlayerItems { get; set; }
        public virtual Location PlayerLocation { get; set; }

        public Player()
        {
        }
        public Player(string name)
        {
            Name = name;
            Avatar = new byte[0];
            Health = 100;
            LocationId = 1;
        }
    }
}
