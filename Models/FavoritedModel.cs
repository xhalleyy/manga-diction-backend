using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace manga_diction_backend.Models
{
    public class FavoritedModel
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string? MangaId { get; set; }
        public bool Completed { get; set; }
        public FavoritedModel()
        {
            
        }
    }
}