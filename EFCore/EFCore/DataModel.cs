using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    [Table("Item")]
    public class Item
    {
        // 이름 Id -> PK
        public int ItemId { get; set; }
        public int TemplateId { get; set; }
        public DateTime CreatedDate { get; set; }
        // 다른 클래스 참조 -> FK ( Navigational Property)
        public int OwnerId { get; set; }
        public Player Owner { get; set; }
    }
    // 클래스 이름 = 테이블 이름
    public class Player
    {
        // 이름 Id -> PK
        public int PlayerId { get; set; }
        public string Name { get; set; }
    }
}
