using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
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
        public string UserId { get; set; }
        public virtual ICollection<PlayerItem> PlayerItems { get; set; }
        public virtual Location PlayerLocation { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Obsolete("Only needed for serialization and materialization", true)]
        public Player() { }
        public Player(string userId)
        {
            this.UserId = userId;
        }
        //public Player(string name, int location)
        //{
        //    Name = name;
        //    Avatar = new byte[0];
        //    Health = 100;
        //    LocationId = location;
        //}
    }
}
