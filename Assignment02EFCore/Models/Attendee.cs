using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment02EFCore.Models;
internal class Attendee
{
    [Key]
    public int AttendeeId { get; set; } // PK INT AttendeeId Identity(1,1)


    [Column(TypeName ="VARCHAR")]
    [MaxLength(150)]
    [Required]
    public string FullName { get; set; } // FullName VARCHAR(150) NOTNULL [Mandatory]


    [Column(TypeName = "VARCHAR")]
    [MaxLength(200)]
    [Required]
    [DataType(DataType.EmailAddress)] //UI Hint [not mapped to db]
    public string Email { get; set; } // Email VARCHAR(200) NOTNULL [Mandatory]


    [Column(TypeName = "VARCHAR")]
    [MaxLength(150)]
    [Required]
    public string Street { get; set; } // Street VARCHAR(150) NOTNULL [Mandatory]


    [Column(TypeName = "VARCHAR")]
    [MaxLength(100)]
    [Required]
    public string City { get; set; } // City VARCHAR(100) NOTNULL [Mandatory]


    [Column(TypeName = "VARCHAR")]
    [MaxLength(100)]
    [Required]
    public string Country { get; set; } // Country VARCHAR(100) NOTNULL [Mandatory]


    [Column("ZipCode", TypeName = "VARCHAR")]
    [MaxLength(20)]
    [Required]
    public string PostalCode { get; set; } //ZipCode VARCHAR(20) NOTNULL [Mandatory]
                                           //ZipCode as the priority is for data annotation not convention


    [NotMapped]
    public string FullAddress => $"{Street}, {City}, {Country}, {PostalCode}"; //ReadOnlyProp [It will not be mapped to db].


}