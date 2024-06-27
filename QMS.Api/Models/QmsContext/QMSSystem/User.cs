using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QMS.Api.Models.QmsContext.QmsSystem
{
    public class User : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [StringLength(100)]
        public string Username { get; set; } // 用户名

        [Required]
        [StringLength(100)]
        public string UserNo { get; set; } // 账号

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } // 邮箱地址

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; } // 密码哈希

        [StringLength(100)]
        public string FirstName { get; set; } // 名

        [StringLength(100)]
        public string LastName { get; set; } // 姓

        [Phone]
        [StringLength(15)]
        public string PhoneNumber { get; set; } // 电话号码

        public DateTime? DateOfBirth { get; set; } // 生日

        [StringLength(200)]
        public string Address { get; set; } // 地址

        [StringLength(20)]
        public string Role { get; set; } // 角色 (例如：Admin, User, etc.)

        public bool IsActive { get; set; } = true; // 用户是否活跃

        public DateTime? LastLoginDate { get; set; } // 上次登录时间
    }
}
