using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public string FirstName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string Ticket { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
