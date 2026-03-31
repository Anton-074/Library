using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Book
{
    public int Id { get; set; }

    public int IdAuthor { get; set; }

    public int IdGenre { get; set; }

    public int IdPublishingHouse { get; set; }

    public string Isbn { get; set; } = null!;

    public int Year { get; set; }

    public string Pages { get; set; } = null!;

    public int TotalCopies { get; set; }

    public int AvailableCopies { get; set; }

    public string Annotation { get; set; } = null!;

    public virtual Author Author { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual PublishingHouse PublishingHouse { get; set; } = null!;

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
