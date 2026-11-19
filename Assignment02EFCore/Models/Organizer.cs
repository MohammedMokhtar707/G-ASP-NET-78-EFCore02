using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment02EFCore.Models;

[Table("EventOrganizers",Schema ="dbo")]
internal class Organizer
{
    //We write annotations or attributes inside []
    [Key]
    public int OrganizerId { get; set; } //PK INT OrganizerId Identity(1,1)


    [Column(TypeName ="VARCHAR")]
    [MaxLength(100)]
    [Required]
    public string Name { get; set; } //Name VARCHAR(100) NOTNULL [Mandatory]


    [Column(TypeName = "VARCHAR")]
    [MaxLength(150)]
    public string? CompanyName { get; set; } //CompanyName VARCHAR(150) NULL [Optional]


    public bool IsVerified { get; set; } //IsVerified BIT NOTNULL [Mandatory]

}
