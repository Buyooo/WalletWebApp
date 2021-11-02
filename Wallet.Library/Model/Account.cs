using System;
using System.ComponentModel.DataAnnotations;

namespace Wallet.Library.Model
{
    public class Account
    {
        // I'd like to use Guid but it's not completly supported by SQLite
        // so I'm going to add Guids as string
        [Key]
        public string Id { get; set; }

        public int Balance { get; set; }
    }
}
