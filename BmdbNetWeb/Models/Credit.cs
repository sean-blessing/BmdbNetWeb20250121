using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BmdbNetWeb.Models;

[Table("Credit")]
[Index("MovieId", "ActorId", Name = "UQ_Credit_Movie_Actor", IsUnique = true)]
public partial class Credit
{
    [Key]
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int ActorId { get; set; }

    //[StringLength(255)]
    //[Unicode(false)]
    public string Role { get; set; } = null!;

    //[ForeignKey("ActorId")]
    //[InverseProperty("Credits")]
    public Actor? Actor { get; set; } = null!;

    //[ForeignKey("MovieId")]
    //[InverseProperty("Credits")]
    public Movie? Movie { get; set; } = null!;
}
