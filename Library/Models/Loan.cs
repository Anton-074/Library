using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Loan
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public DateOnly DateIssue { get; set; }

    public DateOnly PlannedReturnDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public int IdStatus { get; set; }

    public int? IdBook { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
