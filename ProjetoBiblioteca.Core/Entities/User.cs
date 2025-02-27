using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Update.Internal;
using ProjetoBiblioteca.Core.Entities;


namespace ProjetoBiblioteca.Core.Entities;

public class User: BaseEntity
{
        public User( string name, string email, bool active, List<Loan> loansList)
            : base()
        {
            
            Name = name;
            Email = email;
            Active = active;
            LoansList = loansList ?? new List<Loan>();
        }
        
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }

        public List<Loan> LoansList { get; private set; }

        protected User() { } 

        public User(string name, string email)
            : base()
        {
            Name = name;
            Email = email;
            Active = true;
            LoansList = new List<Loan>();
        }

        public void Update(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

